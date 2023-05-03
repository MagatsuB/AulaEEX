using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicoes : MonoBehaviour
{
    [SerializeField]int _i1, _i2;
    [SerializeField]string _t1, t2;
    [SerializeField]float _f1, _f2;
    [SerializeField]bool _b1, _b2;

    // > Maior
    // < Menor
    // <= Menor ou igual
    // >= Maior ou igual
    // != Diferente
    // == igual
    // && e
    // || OU

    // Start is called before the first frame update
    void Start()
    {
        //_i1 = 1;
        //if (_i1 == 1) {
        //    Debug.Log("fase 1 liberada ");
        //}
        //else
        //{
        //    Debug.Log("Fase 1 bloqueada ");
        //}

        // se t1 for igual a multiplicação 
        //multiplicar i1 com a i2 
        // se nao somar i1 com i2

        //_i1 = 2; _i2 = 4;
        //
        //if(_t1 == "multiplicacao")
        //{
        //    int _mult = _i1 * _i2;
        //    Debug.Log("A Multiplicação entre i1 e i2 é " + _mult);
        //}
        //else
        //{
        //    int _soma = _i1 + _i2;
        //    Debug.Log("A soma entre i1 e i2 é " + _soma);
        //}


        //Se a _i1 for igual a 2
        //a _t1 escreve passagem liberada
        //se não _t1, passagem bloqueada

        _i1 = 1;
        if(_i1 == 2)
        {
            _t1 = "Passagem Liberada";
        }
        else
        {
            _t1 = "Pasagem Bloqueada";
        }

        //Debug.Log(_t1);

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
