using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class JoystickMovement : MonoBehaviour

{
	public GameObject dialogbox;
	public string dialog;
	public Vector3 start;
	private float speed = 7f;
	public float health = 5f;
	float velX;
	float velY;
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

	void Start()
	{
		myRigidBody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		MoveCharacter();
		HealthSystem();
		RestartSystem();
	}
	
	private void MoveCharacter()
	{
		change = Vector3.zero;
		change.x = CrossPlatformInputManager.GetAxis("Horizontal");
		change.y = CrossPlatformInputManager.GetAxis("Vertical");
		if (change != Vector3.zero)
		{
			myRigidBody.MovePosition(this.transform.position + change * speed * Time.deltaTime);
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
                    FindObjectOfType<AudioManager>().Play("PlayerHit");
                }

				else
				{
					health--;
				}

			}
		}
	}
}

