using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionais_Combinadas : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] Rigidbody _cubeRig;
    [SerializeField] BoxCollider _cubeBox;
    
    [SerializeField] GameObject _sphere;
    [SerializeField] Rigidbody _spherRig;
    
    [SerializeField] GameObject _capsule;
    [SerializeField] Rigidbody _capsuRig;


    [SerializeField] GameObject _cylinder;
    [SerializeField] Rigidbody _cylindRig;

    //variavel texto com nome _text
    //variavel de numeros decimais com o nome _number
    //variavel boleana com o nome _check

    [SerializeField] string _text;
    [SerializeField] int _number;
    [SerializeField] bool _check;
    // Start is called before the first frame update
    void Start()
    {
        _cubeBox = _cube.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_check == true && _number == 1)
        {
            _cube.SetActive(true);
            _cubeRig.useGravity = false;


        }else if (_check == true && _number == 2)
        {
            _cube.SetActive(false);
            _sphere.SetActive(true);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }
    }
}
