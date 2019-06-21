using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    public bool isOnGround;
   public  float ymove = 3;
    public float speed = 2.5f;
    private Shooter shoot;
    // Use this for initialization
    void Start () {
        shoot = GetComponent<Shooter>();
	}
	
	// Update is called once per frame
	void Update () {
        
        float xmove = Input.GetAxis("Horizontal");
       

        GetComponent<Rigidbody2D>().velocity = new Vector2(xmove * speed, GetComponent<Rigidbody2D>().velocity.y);


        if (Input.GetButtonDown("Jump"))
        {
            if(isOnGround == true)
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ymove;
        }

        if (Input.GetButton("Fire1"))
        {
            shoot.Fire();
        }

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        isOnGround = false;
    }
}
