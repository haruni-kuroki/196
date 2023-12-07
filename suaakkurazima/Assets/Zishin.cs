using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zishin : MonoBehaviour
{
    // Start is called before the first frame update
    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 5.7f;
    public float dampingSpeed = 1.0f;

    Vector3 initialPosition;
    bool isShaking = false;

    void Start()
    {
        initialPosition = transform.localPosition;
        
        Invoke("TriggerShake",3.0f);
    }

    void Update()
    {
        if (isShaking)
        {
            if (shakeDuration > 0)
            {
                transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
                shakeDuration -= Time.deltaTime * dampingSpeed;
            }
            else
            {
                isShaking = false;
                shakeDuration = 0f;
                transform.localPosition = initialPosition;
            }
        }
    }

    public void TriggerShake()
    {
        isShaking = true;
    }
}


