using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;
    [SerializeField] bool _checkCube;
    [SerializeField] bool _checkSphere;
    [SerializeField] bool _checkCapsule;
    [SerializeField] bool _checkCylinder;
    [SerializeField] string _texto;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    

    // Update is called once per frame
    void Update()
    {
     _cube.SetActive(false);
     _sphere.SetActive(false);
     _capsule.SetActive(false);
     _cylinder.SetActive(false);

        _checkCube = false;
        _checkSphere = false;
        _checkCapsule = false;
        _checkCylinder = false;

        if (_texto == "cube" || _texto == "Cube" || _texto == "CUBE")
        {
            _checkCube = true;
            if (_checkCube == true)
            {
                _cube.SetActive(true);
            } else
            {
                _cube.SetActive(false);
                _checkCube = false;
            }
        }
        if (_texto == "sphere" || _texto == "Sphere" || _texto == "SPHERE")
        {
            _checkSphere = true;
            if (_checkSphere == true)
            {
                _sphere.SetActive(true);
            }
            else
            {
                _sphere.SetActive(false);
                _checkSphere = false;
            }
        }
        if (_texto == "capsule" || _texto == "Capsule" || _texto == "CAPSULE")
        {
            _checkCapsule = true;
            if (_checkCapsule == true)
            {
                _capsule.SetActive(true);
            }
            else
            {
                _capsule.SetActive(false);
                _checkCapsule = false;
            }
        }
        if (_texto == "cylinder" || _texto == "Cylinder" || _texto == "CYLINDER")
        {
            _checkCylinder = true;
            if (_checkCylinder == true)
            {
                _cylinder.SetActive(true);
            }
            else
            {
                _cylinder.SetActive(false);
                _checkCylinder = false;
            }
        }
    }
}
