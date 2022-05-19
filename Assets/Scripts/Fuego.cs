using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private Interfaz_controller sliderTemperatura;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Temperatura", sliderTemperatura.temperaturaActual);
    }
}
