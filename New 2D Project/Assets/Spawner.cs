using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private Shooter shooter;
    

	// Use this for initialization
	void Start () {
        shooter = GetComponent<Shooter>();
	}
	
	// Update is called once per frame
	void Update () {
		if (shooter.canshoot == true)
        {
            shooter.Fire();
        }
	}
}
