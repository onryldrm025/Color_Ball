using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kemera1 : MonoBehaviour {

    public GameObject top;          // Oyun alınmdaki topum
    float mesafe;                   
	
	void Start () {
        mesafe = transform.position.z - top.transform.position.z;   //aradaki Mesafeyi alıyoruz (sadece z ekseni alıyoruz nedeni Evatıcılar rotasyonu)
		
	}
	

	void Update () {
        if (top !=null)
        {
            float yeni = top.transform.position.z + mesafe;
            transform.position = new Vector3(transform.position.x, transform.position.y, yeni);
        }
       
		
	}
}
