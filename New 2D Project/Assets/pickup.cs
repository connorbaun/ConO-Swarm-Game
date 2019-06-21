using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {
    public GameObject particles;
    public int minAmount;
    public int maxAmount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Collider2D>().tag == "Player")
        {
           
            GameObject clone = Instantiate(particles);
            clone.transform.position = collision.transform.position;
            Destroy(clone, 1);
            Destroy(gameObject);
            collision.gameObject.GetComponent<ammomanager>().ManageAmmo(Random.Range(minAmount,maxAmount));
            
        }
    }
}
