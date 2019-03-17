using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particile : MonoBehaviour {


    public GameObject top;
    int durum = 0;
    
   
    void Start () {

    }

  
    void Update () {
        var exp = GetComponent<ParticleSystem>();
        ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
        /*top.transform.position.y>1  durum==0 */

        if (  top ==null)
        {
            exp.Stop();
          //  durum = 1;


        }
        /*
        if (durum == 2)
        {
            exp.Play();
            durum = 0;
        }
        */

        if (top != null)
        {

            if (top.tag == "Mavi")
            {

                settings.startColor = new ParticleSystem.MinMaxGradient(new Color(0, 0, 248, 255));


            }
            if (top.tag == "Sarı")
            {

                settings.startColor = new ParticleSystem.MinMaxGradient(new Color(238, 248, 0, 255));

            }
            if (top.tag == "Kırmızı")
            {
                settings.startColor = new ParticleSystem.MinMaxGradient(new Color(248, 0, 0, 255));


            }


        }
     


    }
}
