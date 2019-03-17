using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrap : MonoBehaviour {
    Rigidbody fizik;
  
    public GameObject top;                  //Oyundaki Topum
    public GameObject patlamakirmizi;       // Kırmızı patlama effect  
    public GameObject patlamasari;          //Sarı patlama effect
    public GameObject patlamamavi;          // Maci patlama effect
    GameObject ısınobje;                    // Efecti olusturmak iin obje                         
    int durum = 1;                          // Kare tuzağı sağa veya sola çevirmek için  ----- 1 sola -1 sağa
    AudioSource ses;

    void Start () {
        ses = GetComponent<AudioSource>();
  

    }


    void OnTriggerEnter(Collider col)
    {
        durum = durum * -1;                                 // Kare tuzak önce soldan sağa gitmesini sağlar
        if (col.transform.gameObject.tag!="Yer")           // Çarpan nesnenin tagı yer değilse gir
        {

            // ---------------------------------------------------------------------------------------------------------
            if (col.tag == "Kırmızı")                                                               
            {
                ısınobje = Instantiate(patlamakirmizi, col.transform.position, col.transform.rotation);
                ses.Play();
                Destroy(ısınobje, 3);
            }
            if (col.tag == "Sarı")
            {
                ısınobje = Instantiate(patlamasari, col.transform.position, col.transform.rotation);                    // Patlama Effectleri
                ses.Play();
                Destroy(ısınobje, 3);
            }
            if (col.tag == "Mavi")
            {
                ısınobje = Instantiate(patlamamavi, col.transform.position, col.transform.rotation);
                ses.Play();
                Destroy(ısınobje, 3);
            }
            //------------------------------------------------------------------------------------------------------
            Destroy(col.gameObject);     // Çarpan nesneyi sil
        }

        }

    void durumdegis()               // Kare tuzağın sağ sol yapması için
    {
      
        durum = durum * -1;
    }
	

	void Update () {
        

        transform.Translate(durum *-4f * Time.deltaTime, 0, 0);
        



    }
}
