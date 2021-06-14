using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRenderer : MonoBehaviour
{
    [SerializeField]private Transform _player;
    private Vector3 _offset;
    private Vector3 _newPosition;

   
   private void Start()
    {

        _offset = transform.position - _player.position;
        
    }

   
    private void FixedUpdate()
    {
        _newPosition = new Vector3(_offset.x + _player.position.x, _offset.y + _player.position.y, _offset.z + _player.position.z);
        transform.position = _newPosition;
    }
}
