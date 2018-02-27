using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Javeline : MonoBehaviour {

	private bool isPressed = false;
	private Rigidbody2D rb;

	public SpringJoint2D joint;
	public float releaseTime = 0.1f;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if(isPressed)
		{
			rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}

	void OnMouseDown()
	{
		isPressed = true;
		rb.isKinematic = true;
	}

	void OnMouseUp()
	{
		isPressed = false;
		rb.isKinematic = false;

		StartCoroutine(released());
	}

	IEnumerator released()
	{
		yield return new WaitForSeconds(releaseTime);

		joint.enabled = false;
	}
	
}
