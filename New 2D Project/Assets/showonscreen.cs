using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showonscreen : MonoBehaviour {
    public Text textSlot;
    public Text ammoSlot;
    public string value;
    public string ammoValue;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        textSlot.text = value.ToString();
        ammoSlot.text = ammoValue.ToString();
	}
}
