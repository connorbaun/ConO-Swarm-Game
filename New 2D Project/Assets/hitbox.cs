using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour {

    private killable myStatus;

	// Use this for initialization
	void Start () {
        myStatus = GetComponent<killable>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<dealdamage>() != null)
        {
            Debug.Log("enemy touchin");
            myStatus.TakeDamage(collision.gameObject.GetComponent<dealdamage>().damageAmount);
        }
        Debug.Log("WEINER HNOLE");
    } */

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<dealdamage>() != null)
        {
            myStatus.TakeDamage(collision.gameObject.GetComponent<dealdamage>().damageAmount);
        }
    }
}
