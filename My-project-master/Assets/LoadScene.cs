using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
     void Start()
    {
        Debug.Log("LoadSceneA");
    }

   public void loadA(string scenename){
       Debug.Log("SceneName to load: " + scenename);
       SceneManager.LoadScene(scenename);
   }
}
