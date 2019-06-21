using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosive : MonoBehaviour {
    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Collider2D>().tag == "enemy")
        {
            Destroy(collision.gameObject);
            GameObject clone = Instantiate(explosionPrefab);
            clone.transform.position = collision.transform.position;
            if (collision.gameObject.GetComponent<loot>() != null)
            {
                collision.gameObject.GetComponent<loot>().DropLoot(collision.contacts[0].point);
            }
            
            Destroy(clone, 1);
            Destroy(gameObject);
            Debug.Log("whack");
        }
    }
}
