using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolVertical : MonoBehaviour
{
	public float speed;
	private float distance = 0;

	private bool movingDown = true;

	public Transform groundDetection;

	void Update()
	{
		transform.Translate(Vector2.down * speed * Time.deltaTime);

		RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.right, distance);
		if (groundInfo.collider == true)
		{
			if (movingDown == true)
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
				movingDown = false;
			}
			else
			{
				transform.eulerAngles = new Vector3(180, 0, 0);
				movingDown = true;
			}

		}
	}
}
