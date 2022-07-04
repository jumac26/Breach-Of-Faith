﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolHorizontal : MonoBehaviour
{
	public float speed;
	private float distance = 0;

	private bool movingRight = true;

	public Transform groundDetection;
	
	void Update()
	{
		transform.Translate(Vector2.right * speed * Time.deltaTime);

		RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
		if (groundInfo.collider == true)
		{
			if (movingRight == true)
			{
				transform.eulerAngles = new Vector3(0, -180, 0);
				movingRight = false;
			}
			else
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
				movingRight = true;
			}

		}
	}

}
