using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammomanager : MonoBehaviour {
    public int ammo;
    public Shooter shoot;
    public showonscreen screen;
	// Use this for initialization
	void Start () {
        shoot = GetComponent<Shooter>();
        //screen = GetComponent<showonscreen>();
	}
	
	// Update is called once per frame
	void Update () {
		if(ammo <= 0)
        {
            shoot.canshoot = false;
            shoot.timer = 0;
        }
        screen.ammoValue = ammo.ToString();
	}
    public void ManageAmmo(int amount)
    {
        ammo += amount;
    }
}
