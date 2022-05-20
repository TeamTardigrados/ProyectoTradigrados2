using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TardigradoController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    [SerializeField]Interfaz_controller interfazController;
    [SerializeField]Humedad humedad;
    public bool isDried = true;
    private SoundManager soundManager;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }
    private void OnEnable()
    {
        humedad.OnWaterEnd += Dried;
        humedad.OnGetWater += Hydrated;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Temperatura", interfazController.temperaturaActual);

    }

    public void Dried()
    {
        anim.SetBool("isDried", true);
        //soundManager.SeleccionAudio(0, 0.5f);
    }

    public void Hydrated()
    {
        anim.SetBool("isDried", false);
    }

    private void OnDisable()
    {
        humedad.OnWaterEnd -= Dried;
        humedad.OnGetWater -= Hydrated;
    }
    
}
