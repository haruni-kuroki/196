using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaishoEruption : MonoBehaviour
{
    ParticleSystem particle;

    ParticleSystem.MainModule main;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        main = particle.main;
        main.startLifetimeMultiplier = 0;
        StartCoroutine("StartEruption");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartEruption()
    {
        yield return new WaitForSeconds(3.0f);
        for(int i = 0;i <= 40;i++)
        {
            main.startLifetimeMultiplier=i;
            transform.localScale = new Vector3(5,5,5) * Mathf.Log(i + 1,2);
            // transform.localScale = new Vector3(1,1,1) * i/2;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
