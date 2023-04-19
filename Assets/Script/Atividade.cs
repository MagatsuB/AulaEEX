using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Declarar variavel de texto
    //Implementar valor somente na 1º
    //Alterar a 1º Variavel 

    //Na Função Start
    //Concatenar a 1º 2º e 3º Variavel

    [SerializeField] string _DiaNascimento = "17";
    [SerializeField] string _MesNascimento;
    [SerializeField] string _AnoNascimento;
    [SerializeField] string _DataDeNascimento;
    // Start is called before the first frame update
    void Start()
    {
        _DataDeNascimento = _DiaNascimento = 09 + "/" + _MesNascimento + "/" + _AnoNascimento;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
