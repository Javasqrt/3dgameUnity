using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI; 

public class Hit : MonoBehaviour
{
   
    [SerializeField] private GameObject _loseScreen;
    private GameObject _gameObject;
  
    private Rigidbody _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _gameObject = GetComponent<GameObject>();
    }
 


    void Update()
    {

        Ray ray = new Ray(transform.position, Vector3.forward);
        var hit = Physics.Raycast(ray);
        if (!hit.Equals(gameObject))
        {
            _rb.AddForce(Vector3.forward);

        }
              if(_gameObject.transform.localScale == new Vector3(_gameObject.transform.localScale.x * 0.2f, _gameObject.transform.localScale.y * 0.2f, _gameObject.transform.localScale.z * 0.2f) )
        {
            _loseScreen.SetActive(true);
            var button = _loseScreen.GetComponent<Button>();

        }


    }
}
