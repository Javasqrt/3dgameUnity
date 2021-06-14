using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpot : MonoBehaviour
{
    [SerializeField] private GameObject _objectWall;
    [SerializeField] private float _objectCount;

    private GameObject _currentObject;

    private Transform[] _spot;
    void Awake()
    {
        _spot = GetComponentsInChildren<Transform>();



    }

    private void Start()
    {

        for (int i = 1; i <= _objectCount; i++)
        {
            _currentObject = Instantiate(_objectWall);
            _currentObject.transform.position = _spot[i].position;



        }


    }
   

}
