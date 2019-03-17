using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomtrapCube : MonoBehaviour {

    public GameObject[] spawness;
    public Transform spawnPos;
    GameObject speed;
    GameObject random;
    

    GameObject cubetrap;
    

    void Start()
    {
    }


    void Update()
    {


    }

    void Randomcome()

    {
        float x = Random.Range(-2.0f, 1.84f);
        int y = Random.Range(0, 6);
    
        random = spawness[y];

        Vector3 Cubevek = new Vector3(x, 0.62f, spawnPos.position.z);
        if(random.tag=="Hizlan")
        {
             Cubevek = new Vector3(x *-1, 0.1f, spawnPos.position.z);
        }
        if (random.tag == "Oynartuzak")
        {
            Cubevek = new Vector3( 0, 3.3f, spawnPos.position.z);

        }
        if(random.tag=="Ltuzak")
        {
            Cubevek = new Vector3(0.24f, 0.64f, spawnPos.position.z);
        }

        cubetrap = Instantiate(random, Cubevek, spawnPos.rotation);

        Destroy(cubetrap, 10f);




    }
    public void basla()
    {
        InvokeRepeating("Randomcome", 1, 3);

    }
}
