using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// 風向きのDropdownのプログラム
public class Hougaku : MonoBehaviour
{
    //Dropdownを格納する変数
    [SerializeField] private TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { DropDownValueChanged(dropdown); });
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(dropdown.value);
    }

    void DropDownValueChanged(TMP_Dropdown change){

        SimuationManager.kaze = change.value;
       
    }
}
