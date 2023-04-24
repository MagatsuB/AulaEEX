using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Numeros : MonoBehaviour
{
    [SerializeField] int _strgravity;
    [SerializeField] int _weakgravity;
    [SerializeField] float _gravidade;
    [SerializeField] GameObject _ball;
    [SerializeField] Rigidbody _rig;
    [SerializeField] Text _tex;

    // Start is called before the first frame update
    void Start()
    {
        //_rig.useGravity = true;
        _gravidade = _gravidade * 3;
        _tex.text = "Gravidade =  " + _gravidade;
        
    }

    // Update is called once per frame
    void Update()
    {
        _rig.mass = _gravidade ;
        

    }
}
