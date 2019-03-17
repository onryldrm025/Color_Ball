using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

    public Canvas bitis;
    public GameObject patlamakirmizi;
    public GameObject patlamasari;
    public GameObject patlamamavi;
    GameObject ısınobje;
    public GameObject top;
    AudioSource ses;
    int levelup;
    void Start()
    {
        bitis.enabled = (false);
        ses = GetComponent<AudioSource>();
   


    }
    void Update()
    {
        ParticleSystem.MainModule settings = GetComponent<ParticleSystem>().main;
        if(top != null)
        {




            if (top.tag == "Mavi")
            {

                settings.startColor = new ParticleSystem.MinMaxGradient(new Color(0, 0, 248, 255));
                ses.Play();


            }
            if (top.tag == "Sarı")
            {

                settings.startColor = new ParticleSystem.MinMaxGradient(new Color(238, 248, 0, 255));
                ses.Play();

            }
            if (top.tag == "Kırmızı")
            {
                settings.startColor = new ParticleSystem.MinMaxGradient(new Color(248, 0, 0, 255));
                ses.Play();


            }





        }
      




    }



    void OnTriggerEnter(Collider col)
    {

        if(col.tag=="Takip")
        {
            Destroy(col.gameObject);
        }

        if (col.tag != "Takip")
        {
            bitis.enabled = (true);
            if (col.transform.gameObject.tag != transform.gameObject.tag)
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



                Destroy(col.gameObject);
                Destroy(ısınobje, 2);

            }
            levelup = int.Parse(Application.loadedLevelName);
            PlayerPrefs.SetInt("Level", int.Parse(Application.loadedLevelName) + 1);

        }

       
         
      


    }
   public void levelatla()
    {
        SceneManager.LoadScene(levelup);

    }


   





}
