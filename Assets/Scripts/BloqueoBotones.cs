using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloqueoBotones : MonoBehaviour
{
    [SerializeField] private Button misionesBTN;
    [SerializeField] private Button GoteroBTN;
    [SerializeField] private Slider sliderTemp;
    [SerializeField] private Slider sliderRadi;

    void Start()
    {
        misionesBTN.interactable = false;
        GoteroBTN.interactable = false;
        sliderTemp.interactable = false;
        sliderRadi.interactable = false; 
    }
}
