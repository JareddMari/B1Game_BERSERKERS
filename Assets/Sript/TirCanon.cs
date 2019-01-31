using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirCanon : MonoBehaviour {
    public GameObject Projectil;
    [SerializeField] private Transform CanonTip;
    public int force = 1; 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        
            if (Input.GetMouseButtonDown(0))
            {
                GameObject Boule = Instantiate(Projectil, CanonTip.position, CanonTip.rotation) as GameObject;

            }
        }
    }