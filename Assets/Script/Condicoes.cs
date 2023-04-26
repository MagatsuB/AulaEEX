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


    // Start is called before the first frame update
    void Start()
    {
        //if (_i1 == 1) {
        //    Debug.Log("O valor de i1 é: " + _i1);
        //}
        //else
        //{
        //    Debug.Log("O Valor de i1 não é 1");
        //}

        _i1 = 1;
        _i2 = 1;
           if(_i1 == _i2)
        {
            Debug.Log("Valor de i1 é igual a i2");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
