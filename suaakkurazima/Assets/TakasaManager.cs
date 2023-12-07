using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TakasaManager : MonoBehaviour
{
    ParticleSystem particle;
    ParticleSystem.MainModule main;

    float max_tall = 8000;
    //噴煙の高さを選択するプログラム
    public Text tall_text;
    float[] tall = new float[] {1000,3000,5000,8000};
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        main = particle.main;
        main.startLifetimeMultiplier = 0;
        // Debug.Log(SimuationManager.takasa);
        tall_text.text = Convert.ToString(tall[SimuationManager.takasa]) + "m";
        max_tall = tall[SimuationManager.takasa];
        StartCoroutine("StartEruption");
    }

    IEnumerator StartEruption()
    {
        for(int i = 0;i <= max_tall/100;i++)
        {
            main.startLifetimeMultiplier=i;
            // transform.localScale = new Vector3(5,5,5) * Mathf.Log(i + 1,2);
            // transform.localScale = new Vector3(1,1,1) * i/2;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
