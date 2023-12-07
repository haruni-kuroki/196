using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TallChanger : MonoBehaviour
{
    //高さのdropdown
   [SerializeField] private TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { DropDownValueChanged(dropdown); });
    }

    // Update is called once per frame
    void Update()
    {
    }

    void DropDownValueChanged(TMP_Dropdown change){
        Debug.Log(dropdown.value);
        SimuationManager.takasa = change.value;
    }
}
