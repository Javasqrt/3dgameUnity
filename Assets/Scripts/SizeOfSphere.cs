using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SizeOfSphere : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    [SerializeField] private GameObject lose_canvas;
    private Transform _gameObject;
    private  float _minChangeSize = 1f;
    private  float _maxChangeSize = 8f;
    private  float _step = 1f;
    private static float _currentScaleSize;






    private void Start()
    {
        _gameObject = GetComponent<Transform>();


        _currentScaleSize = _minChangeSize;
  
    }

    
   private void Update()
    {

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Stationary)
            {
                if (_currentScaleSize <= _maxChangeSize)
                {
                    _currentScaleSize += _step * Time.deltaTime;

                }


               

            }
           
        }

        if (Input.GetMouseButtonUp(0))
        {
            bullet.DeleteOldGameObject();
            Debug.Log(_currentScaleSize);
            bullet.InitBulletWithSize(_currentScaleSize);
            _gameObject.transform.localScale = new Vector3(_gameObject.transform.localScale.x - (_gameObject.transform.localScale.x * (_currentScaleSize / 10f)), _gameObject.transform.localScale.y - (_gameObject.transform.localScale.y * (_currentScaleSize / 10f)), _gameObject.transform.localScale.z - (_gameObject.transform.localScale.z * (_currentScaleSize / 10f)));


        }
      

    }

}
