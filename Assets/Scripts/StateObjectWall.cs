using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateObjectWall : MonoBehaviour
{

    [SerializeField] private Color _reachedColor;
    [SerializeField] private float _destroyTime;
   
   



    private Renderer _material;
    

   


    private void Awake()
    {
        _material = GetComponent<Renderer>();
    }
  
    private void OnTriggerEnter(Collider other)
    {
            
        if(other.TryGetComponent<SphereCollider>(out SphereCollider collider))
        {
            
        

            Debug.Log("Enter");
            
        
            _material.material.color = _reachedColor;
            Destroy(gameObject, _destroyTime);
          if(other.TryGetComponent<BoxCollider>(out BoxCollider box))
            {
                Debug.Log("Enter");


                _material.material.color = _reachedColor;
                Destroy(gameObject, _destroyTime);
            }
          
         
        }
       
        

    }
    public void OnTriggerEnter(bool connect)
    {
        if(connect == true)
        {
            Debug.Log("Enter");


            _material.material.color = _reachedColor;
            Destroy(gameObject, _destroyTime);
        }
            



    }

}
