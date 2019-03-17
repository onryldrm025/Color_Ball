using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kemera : MonoBehaviour {

    public GameObject top;
    Vector3 mesafe;



    void Start () {
        mesafe = transform.position - top.transform.position;
        
		
	}	
	void Update () {
        if(top !=null)
        { 
        transform.position = top.transform.position + mesafe;
        }
    }
}
