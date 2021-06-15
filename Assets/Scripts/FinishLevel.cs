using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private GameObject win_canvas;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<CheckDistanse>(out CheckDistanse hit))
        {
            win_canvas.SetActive(true);
          
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
