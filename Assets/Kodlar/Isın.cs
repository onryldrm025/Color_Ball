using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isın : MonoBehaviour {
    public GameObject ısın;
    public Transform neredem;
    GameObject ısınobje;
    public GameObject top;
    float zaman;
    Vector3 ilk;

    public Topkontrol Top
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
        }
    }

    void Start () {

        ilk = top.transform.position;
        
        InvokeRepeating("cagir", 0.5f, 0.1f);
		
	}

  
    void cagir()
    {
        if (ilk != top.transform.position)
        {
            
            ısınobje = Instantiate(ısın, neredem.transform.position, Quaternion.identity);
            Destroy(ısınobje, 1);

        }
    }
	
	void FixedUpdate () {

       // StartCoroutine(cagir());
               
		
	}
    
}
