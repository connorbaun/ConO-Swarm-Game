using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loot : MonoBehaviour {
    public GameObject gear;
    public float lootChance;
    public float expiration;
    public GameObject gear2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DropLoot(Vector3 pos)
    {
        float roll = Random.Range(0, 100);
        if (roll <= lootChance)
        {
            GameObject clone = Instantiate(gear);
            clone.transform.position = pos;
            Destroy(clone, expiration);
        }
            


        
    }
}
