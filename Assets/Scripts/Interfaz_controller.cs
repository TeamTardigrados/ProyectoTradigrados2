using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interfaz_controller : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Fondo = null;
    [SerializeField] private Slider sliderTemperatura = null;
    [SerializeField] ParticleSystem nieve;
    public Text estadisticaTemperatura;
    public float temperaturaActual=0;

    [SerializeField] private GameObject fuego1;
    [SerializeField] private GameObject fuego2;
    private SoundManager soundManager;

    private void Start()
    {
        temperaturaActual = sliderTemperatura.value;
        SliderTemp();

    }
    private void Awake()
    {
        soundManager = FindObjectOfType<SoundManager>();
        nieve.GetComponent<ParticleSystem>();
    }
    void Update()
    {
        Fuego();
        FuegoRepositioner();
    }
    public void SliderTemp()
    {
        
        if (sliderTemperatura.value >= 0.5)
        {
            //calor
            Fondo.color = Color.Lerp(Color.white, Color.red, sliderTemperatura.value - 0.5f);
            nieve.Stop();
        }
        else
        {
            //frio
            Fondo.color = Color.Lerp(Color.cyan, Color.white, sliderTemperatura.value + 0.5f);
            
            nieve.Play();
        }
        estadisticaTemperatura.text = ((int)(200f * sliderTemperatura.value) - 100f).ToString();

        temperaturaActual = sliderTemperatura.value;
    }
    public void Fuego()
    {
        if(sliderTemperatura.value <= 0.75)
        {
            fuego1.SetActive(false);
            fuego2.SetActive(false);
        }
        else
        {
            fuego1.SetActive(true);
            fuego2.SetActive(true);
            FuegoSound();
        }

    }
    public void FuegoRepositioner()
    {
        if (sliderTemperatura.value > 0.9f)
        {
            fuego1.gameObject.transform.position = new Vector3(248, 199, 0);
            fuego2.gameObject.transform.position = new Vector3(802, 196, 0);
            
        }
        else if (sliderTemperatura.value <= 0.9f)
        {
            fuego1.gameObject.transform.position = new Vector3(248, 114, 0);
            fuego2.gameObject.transform.position = new Vector3(802, 111, 0);
            
        }
    }
    public void FuegoSound()
    {
        if(sliderTemperatura.value == 0.52)
        {
            soundManager.SeleccionAudio(8, 0.2f);
        }
        else if(sliderTemperatura.value == 0.52)
        {
            soundManager.SeleccionAudio(8, 0.9f);
        }
    }

}
