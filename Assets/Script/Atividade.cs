using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    //Declarar variavel de texto
    //Implementar valor somente na 1�
    //Alterar a 1� Variavel 

    //Na Fun��o Start
    //Concatenar a 1� 2� e 3� Variavel

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
