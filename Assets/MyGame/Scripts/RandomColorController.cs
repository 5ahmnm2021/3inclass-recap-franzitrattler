using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RandomColorController : MonoBehaviour
{
    int randomizer;
    public Image colorImage; 

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            randomizer = Random.Range(0, 4);

            if(randomizer == 0)
            {
                colorImage.color = new Color32(255, 205, 25, 255); 
            }
            if(randomizer == 1)
            {
                colorImage.color = new Color32(95, 34, 0, 255); 
            }
            if(randomizer == 2)
            {
                colorImage.color = new Color32(207, 63, 21, 255); 
            }
            if (randomizer == 3)
            {
                colorImage.color = new Color32(102, 47, 84, 255);
            }
        }
    }
}
