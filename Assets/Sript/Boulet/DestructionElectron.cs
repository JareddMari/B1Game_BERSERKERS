using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionElectron : MonoBehaviour {

    public GameObject Atome;

	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerEnter(Collider Atome)
    {
        Destroy(Atome.gameObject);
        //Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
