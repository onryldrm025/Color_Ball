using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    
	void Start () {
       
        
       if (PlayerPrefs.GetInt("Level") != 0) 
       {
           SceneManager.LoadScene(PlayerPrefs.GetInt("Level") -1 );
         
      }
        else
       {
          
       }
        
     // PlayerPrefs.DeleteAll();

    }
	

	void Update () {
		
	}
}
