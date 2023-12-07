using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EruptionBefore : MonoBehaviour
{
    //噴火画面に移るときのプログラム
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void EruptionStart(){
        SceneManager.LoadScene("Eruption");
    }
}