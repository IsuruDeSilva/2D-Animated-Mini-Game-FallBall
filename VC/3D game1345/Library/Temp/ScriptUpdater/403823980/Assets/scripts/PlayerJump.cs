using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour 
{
	public Transform groundCheck;
     	bool grounded = false;
     	public int jumpSpeed;     

     	void Update () 
     	{
         		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1<< LayerMask.NameToLayer("Ground"));
         		if ((Input.GetKeyDown("space"))&&(grounded))
         		{
             			GetComponent<Rigidbody2D>().AddForce(transform.up*jumpSpeed);
             			grounded = false; //so you can jump only once
         		}
                             
     	}
}