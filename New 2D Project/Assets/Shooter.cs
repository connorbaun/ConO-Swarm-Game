using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public GameObject projectile;
    public Transform bulletpoint;
    public float speed;
    public bool canshoot;
    public float rateOfFire;
    public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (canshoot == false)
        {
            timer += Time.deltaTime;
            if (timer >= rateOfFire)
            {
                canshoot = true;
                timer = 0;

            }
        }
    }

    public void Fire()
    {
        if (canshoot)
        {
            canshoot = false;
            GameObject clone = Instantiate(projectile, bulletpoint.position, transform.rotation);

            if (GetComponent<ammomanager>() != null)
            {
                GetComponent<ammomanager>().ManageAmmo(-1);
            }
        }

       
    }
}
