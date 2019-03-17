using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCapsul : MonoBehaviour {

    public GameObject[] spawness;       
    public Transform spawnPos;
    GameObject capsul;
    GameObject obje;
    GameObject cubetrap;
    GameObject speed;

    void Start () {
        
    }
	
	
	void Update () {


    }

    void Randomcome()

    {
        float x = Random.Range(-2.0f, 1.84f);
        int y = Random.Range(0, 3);
       
        Vector3 cabsulvec = new Vector3(x, spawnPos.position.y, spawnPos.position.z);

        capsul = Instantiate(spawness[y], cabsulvec, spawnPos.rotation);
        Destroy(capsul, 8f);

        //Vector3 hiz = new Vector3(x, 0.1f, spawnPos.position.z);
        //if (obje.tag == "Hizlan")

        //{

        //   speed = Instantiate(spawness[y], hiz, spawnPos.rotation);
        //   Destroy(speed, 10f);
        //}

        //     Vector3 karevek = new Vector3(x, 0.62f, spawnPos.position.z);
              

        //    obje = spawness[y];




        //if(obje.tag== "Kup")

        //{
        //    cubetrap = Instantiate(spawness[y], karevek, spawnPos.rotation);
        //    Destroy(cubetrap, 10f);
        //}
    
        //else
        //{


        //}



    }
    public void basla()
    {
        InvokeRepeating("Randomcome", 0.5f, 1);

    }

  

}
