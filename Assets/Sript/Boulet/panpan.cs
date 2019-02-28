using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panpan : MonoBehaviour {
    public GameObject Projectil;
    [SerializeField] private Transform Cube;
    public int force = 1; 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        
            if (Input.GetMouseButtonDown(0))
            {
                GameObject Boule = Instantiate(Projectil, Cube.position, Cube.rotation) as GameObject;

            }
        }
    }