using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EruptionManager : MonoBehaviour
{ 
    //風向きの選択をするプログラム
    public Text kaze_text;
    string[] kazamuki = new string[] {"North","notheast","East","southeast","South","southwest","West","northwest"};
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SimuationManager.kaze);
    }

    // Update is called once per frame
    void Update()
    {
        if (SimuationManager.kaze == 1){
            // SimuationManager.kaze = 
        }
        kaze_text.text = kazamuki[SimuationManager.kaze];
    }
}
