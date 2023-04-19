using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textos : MonoBehaviour
{
    [SerializeField] string _Nome = "Tijuca";
    [SerializeField] string _Sobrenome;
    [SerializeField] string _NomeCompleto;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _Nome = "Jorgeh";
        _NomeCompleto = _Nome + " " + _Sobrenome;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
