using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulsion : MonoBehaviour {

    public float movingSpeed;
    private Vector3 Startposition;


    // Use this for initialization
    void Start () {
        Startposition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddForce(-Vector3.right * Time.deltaTime * movingSpeed, ForceMode.Impulse);
    }

    
}
