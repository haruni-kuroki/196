using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunenMuki : MonoBehaviour
{   

    //噴煙の向きを変えるプログラム
    // Start is called before the first frame update
    void Start()
    {
        Vector3 target = new Vector3(-37, 20, 150);
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SimuationManager.kaze );
        // if(kazamuki == "North"){
        //     Vector3 target = new Vector3(-37, 100, 150);
        //     transform.LookAt(target);
        // }

        if(SimuationManager.kaze == 0){
            Vector3 target = new Vector3(-37, 180, 150);
            transform.rotation = Quaternion.Euler(target);
        }
         if(SimuationManager.kaze == 1){
            Vector3 target = new Vector3(-37, 225, 150);
            transform.rotation = Quaternion.Euler(target);
        }
         if(SimuationManager.kaze == 2){
            Vector3 target = new Vector3(-37, 270, 150);
            transform.rotation = Quaternion.Euler(target);
        }
         if(SimuationManager.kaze == 3){
            Vector3 target = new Vector3(-37, 315, 150);
            transform.rotation = Quaternion.Euler(target);
        }
        if(SimuationManager.kaze == 4){
            Vector3 target = new Vector3(-37, 0, 150);
            transform.rotation = Quaternion.Euler(target);
        }
         if(SimuationManager.kaze == 5){
            Vector3 target = new Vector3(-37, 45, 150);
            transform.rotation = Quaternion.Euler(target);
        }
        if(SimuationManager.kaze == 6){
            Vector3 target = new Vector3(-37, 90, 150);
            transform.rotation = Quaternion.Euler(target);
        }
         if(SimuationManager.kaze == 7){
            Vector3 target = new Vector3(-37, 135, 150);
            transform.rotation = Quaternion.Euler(target);
        }
        
    }
}
