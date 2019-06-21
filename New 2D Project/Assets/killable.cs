using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killable : MonoBehaviour {
    public float HP;
    public float MaxHP;
    public showonscreen screen;


	// Use this for initialization
	void Start () {
        HP = MaxHP;
	}
	
	// Update is called once per frame
	void Update () {
        
        screen.value = HP.ToString();
		if(HP <= 0)
        {
            screen.value = "DEAD";
            HP = 0;
            gameObject.SetActive(false);


        }

        
	}
    public void TakeDamage(float amount)
    {
        HP -= amount;
       

    }
}
