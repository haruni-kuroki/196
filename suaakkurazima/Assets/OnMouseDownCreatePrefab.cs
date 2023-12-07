using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab;
    bool click = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(click == false)
            {
                RaycastHit hit;
                if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,100))
                {
                    GameObject newGameObject = Instantiate(newPrefab) as GameObject;
                    newGameObject.transform.position = new Vector3(-10,5,25);
                    click = true;
                }   
            
            }
            
        }     

    }
}
