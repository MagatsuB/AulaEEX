using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform _Pos;
    [SerializeField] Vector3 _pos2;

    //float
    void Start()
    {
        _Pos.localScale = new Vector3(10,2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
