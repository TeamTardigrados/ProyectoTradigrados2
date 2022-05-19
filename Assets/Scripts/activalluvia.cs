using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activalluvia : MonoBehaviour
{
    [SerializeField] ParticleSystem lluvia;
    //public GameObject rightframe;
    //bool isEnabled = false;

    void Awake()
    {
        lluvia.GetComponent<ParticleSystem>();
    }
    //void Update()
    //{
    //    ButtonClicked();
    //}
    public void ButtonClicked()
    {
        //isEnabled = true;
        //rightframe.SetActive(isEnabled);
        lluvia.Play();
        StartCoroutine(WaitThenLoadEvento3());
        

    }
    private IEnumerator WaitThenLoadEvento3()
    {
        yield return new WaitForSecondsRealtime(3f);
        lluvia.Stop();
        //isEnabled = false;
        //rightframe.SetActive(isEnabled);

    }
}
