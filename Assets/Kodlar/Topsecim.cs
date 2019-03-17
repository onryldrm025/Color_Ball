using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topsecim : MonoBehaviour {

    public static int topdeg;
   
	void Start () {
		
	}
	public void topum(int topdeger)
    {
       topdeg = topdeger;
        PlayerPrefs.SetInt("Top", topdeger);
        PlayerPrefs.SetString("Topum",topdeger.ToString());


    }
  
	
	void Update () {
		
	}
}
