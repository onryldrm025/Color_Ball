using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evatıcı : MonoBehaviour {

    public GameObject[] house;     //Evlerin bunlunduğu ev dizim
    bool oyunbasla;
    
    void Start () {
    
       
       

    }
	void createhouse()
    {
        int newhouse = Random.Range(0, 6);                                                       // Ev sayimiz 6 olduğundan 0-5 arası sayi gelmesini sağlıyoruz
        GameObject obje = Instantiate(house[newhouse], transform.position, transform.rotation);   // Oluşturulan nesnesyi silmek için tutuyoruz
        Destroy(obje, 10f);                                                                  // Oluşturulan evi 10 saniye sonra siliyoruz



    }
	

    public void basla()
    {
        InvokeRepeating("createhouse", 2, 2);        // ev at fonksiyonu 2 saniye sonra çalışmaya başlıcak ve her 2 saniyede tekrar çalışıcak  

    }

	void Update () {

		
	}
}
