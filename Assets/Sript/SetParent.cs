using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent : MonoBehaviour {

    public GameObject Canon;

	// Use this for initialization
	void Start () {
        gameObject.transform.parent = Canon.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
