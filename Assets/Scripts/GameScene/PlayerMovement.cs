using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
	public GameObject dialogbox;
	public string dialog;
	public Vector3 start;
	public float speed;
	public float health = 5f;
    private Rigidbody2D myRigidBody;
    private Vector3 change;
    private Animator animator;
	public GameObject yes;
	public GameObject no;

	public GameObject life1;
	public GameObject life2;
	public GameObject life3;
	public GameObject life4;
	public GameObject life5;
	// Start is called before the first frame update
	void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimationAndMove();
		HealthSystem();
		RestartSystem();
	}
    void MoveCharacter()
    {
		myRigidBody.MovePosition(this.transform.position + change * speed * Time.deltaTime);
		change = Vector3.zero;
		change.x = Input.GetAxisRaw("Horizontal");
		change.y = Input.GetAxisRaw("Vertical");
	}
    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
	private void HealthSystem()
	{
		if (health == 4)
		{
			Destroy(life5.gameObject);
		}
		if (health == 3)
		{
			Destroy(life4.gameObject);
		}
		if (health == 2)
		{
			Destroy(life3.gameObject);
		}
		if (health == 1)
		{
			Destroy(life2.gameObject);
		}
		if (health == 0)
		{
			Destroy(life1.gameObject);
		}
	}
	private void RestartSystem()
	{
		if (health == 0)
		{
			speed = 0;
			{
				if (yes.activeInHierarchy)
				{

				}
				else
				{
					yes.SetActive(true);

				}
				if (no.activeInHierarchy)
				{

				}
				else
				{
					no.SetActive(true);

				}
				if (dialogbox.activeInHierarchy)
				{

				}
				else
				{
					dialogbox.SetActive(true);

				}
			}
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("enemy"))
		{
			if (health >= 1)
			{
				if (health > 1)
				{
					this.transform.position = start;
					health--;
				}
				else
				{
					health--;
				}

			}
		}
	}
}
