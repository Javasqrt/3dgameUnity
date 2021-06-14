using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CheckDistanse : MonoBehaviour
{
   
    [SerializeField] private float _speed;
    private Rigidbody _rb;
   

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
 


   private void Update()
    {
       
        Ray ray = new Ray(transform.position, Vector3.forward);
        var hit = Physics.Raycast(ray);
        if (!hit.Equals(gameObject))
        {
            _rb.AddForce(Vector3.forward);

        }
       

    }
}
