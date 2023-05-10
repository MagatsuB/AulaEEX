using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contolla_Menu : MonoBehaviour
{
    [SerializeField] GameObject _painelIni;
    [SerializeField] GameObject _painelCarreg;
    [SerializeField] GameObject _painelSelecPerson;
  
    public void AtivarPainelIniciar()
    {
        _painelIni.SetActive(true);
        _painelCarreg.SetActive(false);
        _painelSelecPerson.SetActive(false);
    }

    public void AtivarPainelCarregar()
    {
        _painelIni.SetActive(false);
        _painelCarreg.SetActive(true);
        _painelSelecPerson.SetActive(false);
    }

    public void AtivarPainelSelecionarPersonagem()
    {
        _painelCarreg.SetActive(false);
        _painelSelecPerson.SetActive(false);
        _painelSelecPerson.SetActive(true);
    }

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
