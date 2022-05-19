using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activalluvia : MonoBehaviour
{
    public GameObject rightframe;
    public bool isEnabled = false;

    public void ButtonClicked()
    {
        isEnabled = ! isEnabled;
        rightframe.SetActive(isEnabled);
    }
}
