using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Topkontrol : MonoBehaviour {
    Rigidbody fizik;
    float horizontal;
    float vertical;
    public GameObject top;
    public float hiz;
    int puan;
    public Text Puat;
    public Vector3 vek;
    GameObject ısınobje;
    public GameObject patlamakirmizi;
    public GameObject patlamasari;
    public GameObject patlamamavi;
    public Slider levelsilider;
    public GameObject[] plane;
    float road;
    float addfordeger = 7000;
    public Text leveltext;
    bool oyunbasla=false;
    public Canvas baslacanvas;
    public TextMeshProUGUI scoretext;
    public Material[] toplar;
    public int material;
    public Canvas yenidenoyna;
    bool deneme=true;
    int level;
    AudioSource ses;
    public AudioClip cabsul;
   
   
    
    void Start () {

        //   Debug.Log("top:" + PlayerPrefs.GetInt("Top"));
        //   Debug.Log("topum:" + PlayerPrefs.GetString("Topum"));

        ses = GetComponent<AudioSource>();

       
        GetComponent<Renderer>().material = toplar[PlayerPrefs.GetInt("Top")];

        puan = 0;
        fizik = GetComponent<Rigidbody>();
        addfordeger = addfordeger + (int.Parse(Application.loadedLevelName) * 200);
        GetComponent<Renderer>().material.color = Color.red;
        leveltext.text = Application.loadedLevelName.ToString();
    
        yenidenoyna.enabled = false;
        plane = GameObject.FindGameObjectsWithTag("Yer");
      
        road = plane.Length * 35;

        

    }
    void OnTriggerEnter(Collider col)
    {
      

        if (col.transform.tag != transform.gameObject.tag & col.transform.tag !="Yer" & col.transform.tag != "Portal" & col.transform.tag !="Hizlan")
        {
         
 
            yenidenoyna.enabled = true;


        }

        if (col.transform.gameObject.tag == transform.gameObject.tag)
        {
            puan = puan + 10;
            ses.clip = cabsul;
            ses.Play();   
            degis();
        }        
       if (col.tag == "Hizlan")
         {
            addfordeger = addfordeger * 2f;
            Invoke("yavaslan", 3f);
        }
       if(col.tag== "Yerkontrol")
        {
                //bos


        }
      
        
    }
    void degis()
    {
        System.Random rasgel = new System.Random();
        int sayı = rasgel.Next(3);

        if(sayı==0)
        {
            GetComponent<Renderer>().material.color = Color.blue;
            top.tag = "Mavi";

        }
        if (sayı == 1)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            top.tag = "Sarı";

        }
        if (sayı == 2)
        {
            GetComponent<Renderer>().material.color = Color.red;
            top.tag = "Kırmızı";

        }


    }

    void Update () {
    
         if(oyunbasla==true)
        { 

        Puat.text = "Score:"+puan.ToString();
            scoretext.text = puan.ToString();
        // transform.Translate(0, 0, Time.deltaTime*5);
 
        fizik.AddForce(0, 0, addfordeger);
        horizontal = Input.GetAxisRaw("Horizontal");
      //  vertical = Input.GetAxisRaw("Vertical");
       // vek = new Vector3(horizontal, fizik.velocity.y, 0);
       
       fizik.velocity = new Vector3(horizontal*hiz, fizik.velocity.y, 0);
       levelsilider.value = (transform.position.z) / road;
        }





    }
   public void basla()
    {
        baslacanvas.enabled = false;
        GetComponent<Renderer>().material = toplar[PlayerPrefs.GetInt("Top")];
        GetComponent<Renderer>().material.color = Color.red;
        oyunbasla = true;
        


    }
    void yavaslan()
    {
        addfordeger = addfordeger / 2f;
        
    }
}
