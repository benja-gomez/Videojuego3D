using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewController : MonoBehaviour
{
    public GameObject prologo;

    public GameObject starter;

    public Button buttonPrologo;

    public Button buttonVolver;

    void Start()
    {
        buttonPrologo.onClick.AddListener (mostrarPrologo);
        buttonVolver.onClick.AddListener (volver);
        prologo.SetActive(false);
        starter.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void mostrarPrologo()
    {
        starter.SetActive(false);
        prologo.SetActive(true);
    }

    void volver()
    {
        starter.SetActive(true);
        prologo.SetActive(false);
    }
}
