using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Huevo : MonoBehaviour
{
    [SerializeField] private Animator animator = null;
    [SerializeField] private GameObject recogerP = null;
    [SerializeField] private GameObject turbinaCohete = null;
    [SerializeField] private Texto dialoguePanel = null;
    [SerializeField] Button BtnContinuar;
    [SerializeField] private float waitTimeBrokenEgg = 2f;
    private int counter = 0;
    private SoundManager soundManager;

    void Start()
    {
        BtnContinuar.interactable = false;
    }
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    private void OnMouseDown()
    {
        counter++;
        switch (counter)
        {
            case 1:
                animator.SetTrigger("isOpen1");
                soundManager.SeleccionAudio(0, 0.5f);
                break;

            case 2:
                animator.SetTrigger("isOpen2");
                soundManager.SeleccionAudio(0, 0.5f);
                break;

            case 3:
                animator.SetTrigger("isOpen3");
                soundManager.SeleccionAudio(7, 0.5f);
                StartCoroutine(WaitThenLoad());
                break;
        }
    }

    private IEnumerator WaitThenLoad()
    {
        yield return new WaitForSecondsRealtime(waitTimeBrokenEgg);
        recogerP.SetActive(true);
        turbinaCohete.SetActive(true);
        dialoguePanel.LineTemp = 4;
        dialoguePanel.StartDialogue();
        BtnContinuar.interactable = true;
    }
}
