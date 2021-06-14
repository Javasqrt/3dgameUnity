using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _speedBullets;
    [SerializeField] private float _bulletLifeTime;
    
   
    private float _coolDistanse = 5f;
    private Transform _startPosition;
    private GameObject bulletObject;
  


    private void Awake()
    {
        _startPosition = GetComponent<Transform>();
       
    }
   
    private void FixedUpdate()
    {
        _bullet.transform.position = new Vector3(_startPosition.position.x, _startPosition.position.y, _startPosition.position.z + _coolDistanse);
    }
    private void Update()
    {
        if (bulletObject != null)
            bulletObject.transform.position += Vector3.forward * _speedBullets * Time.deltaTime;
       
       
            Destroy(bulletObject,_bulletLifeTime);
          
          
        
        
    }

    public void InitBulletWithSize(float _currentScaleSize)
    {

        bulletObject = Instantiate(_bullet);
        bulletObject.transform.localScale = new Vector3(bulletObject.transform.localScale.x + (bulletObject.transform.localScale.x * (_currentScaleSize / 10f)), bulletObject.transform.localScale.y + (bulletObject.transform.localScale.y * (_currentScaleSize / 10f)), bulletObject.transform.localScale.z + (bulletObject.transform.localScale.z * (_currentScaleSize / 10f)));
        Debug.Log(bulletObject.transform.localScale);
        
    }
    public void DeleteOldGameObject()
    {
        if (bulletObject != null)
        {
            Destroy(bulletObject);
           

        }
    }
    
  }
    
