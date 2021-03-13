using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class Controller : MonoBehaviour
{
  
    void Start()
    {
        
    }


    void Update()
    {
      
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("01ColorScene");
    }
}
