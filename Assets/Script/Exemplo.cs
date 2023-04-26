using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo : MonoBehaviour
{
    [SerializeField]int _number;
    [SerializeField]string _text, _text2;
    [SerializeField]bool _check;
    [SerializeField]float _fnumber;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("A quantidade de cabelos que o Ivo tem é = " + _number);
        _number = 2;
        Debug.Log("A Quantidade de cabelos que o Ivo perdeu por hora é = " + _number);
        _text = "Quero pizza com coca cola";
        Debug.Log(_text);
        _text2 = "E Batata frita";
        Debug.Log(_text2);
        Debug.Log("Valor da Booleana: " + _check);
        _check = true;
        Debug.Log("Agora o Valor da Booleana é: " + _check);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
