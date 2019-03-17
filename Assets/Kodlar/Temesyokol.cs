using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Temesyokol : MonoBehaviour {

    public GameObject top;

    public GameObject patlamakirmizi;
    public GameObject patlamasari;
    public GameObject patlamamavi;
    GameObject ısınobje;
    AudioSource ses;
  
 
    void Start () {
        ses =  GetComponent<AudioSource>();
             
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.tag != transform.gameObject.tag )
        {

           
         

            if (col.tag == "Kırmızı")
            {
                ısınobje = Instantiate(patlamakirmizi, col.transform.position, col.transform.rotation);


                Destroy(ısınobje, 3);
            }
            if (col.tag == "Sarı")
            {
                ısınobje = Instantiate(patlamasari, col.transform.position, col.transform.rotation);
               

                Destroy(ısınobje, 3);
            }
            if (col.tag == "Mavi")
            {
                ısınobje = Instantiate(patlamamavi, col.transform.position, col.transform.rotation);
             

                Destroy(ısınobje, 3);
            }
            ses.Play();
            Destroy(col.gameObject);
            Destroy(ısınobje, 2);
            


        }

        if (col.transform.gameObject.tag == transform.gameObject.tag)
        {
            
            if(col.tag=="Kırmızı")
            {
               
                ısınobje = Instantiate(patlamakirmizi, col.transform.position, col.transform.rotation);
                Destroy(ısınobje, 3);
                Destroy(gameObject);
                
            }
            if (col.tag == "Sarı")
            {
            
                ısınobje = Instantiate(patlamasari, col.transform.position, col.transform.rotation);
                Destroy(ısınobje, 3);
                Destroy(gameObject);
               
            }
            if (col.tag == "Mavi")
            {
               
               
                ısınobje = Instantiate(patlamamavi, col.transform.position, col.transform.rotation);
                Destroy(gameObject);
                Destroy(ısınobje, 3);
                
            }
            


            Destroy(ısınobje, 1);
            
            
        }

    }
   
    void Update () {
        
		
	}
}
