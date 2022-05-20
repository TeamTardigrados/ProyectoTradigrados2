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
    public void ButtonClicked()
    {
        lluvia.Play();
        StartCoroutine(WaitThenLoadEvento3());
    }
    private IEnumerator WaitThenLoadEvento3()
    {
        yield return new WaitForSecondsRealtime(2f);
        lluvia.Stop();
    }
}
