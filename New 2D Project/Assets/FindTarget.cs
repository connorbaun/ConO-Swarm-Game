using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : MonoBehaviour {
    public GameObject _target;
    private CameraFollow follow;
    public string tagToFind;
    public float zRot;

	// Use this for initialization
	void Start () {
        follow = GetComponent<CameraFollow>();
        if (GameObject.FindGameObjectWithTag(tagToFind) != null)
        {
            _target = GameObject.FindGameObjectWithTag(tagToFind);
        }
        else
        {
            _target = FindObjectOfType<Camera>().gameObject;
        }
        zRot = transform.rotation.z;
    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindGameObjectWithTag(tagToFind) != null)
        {
            _target = GameObject.FindGameObjectWithTag(tagToFind);
        }
        else
        {
            _target = FindObjectOfType<Camera>().gameObject;
        }
        follow.target = _target;
        transform.right += new Vector3(_target.transform.position.x, _target.transform.position.y, 0);
	}
}
