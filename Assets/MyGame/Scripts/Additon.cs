using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Additon : MonoBehaviour
{

    public InputField zahl1;
    public InputField zahl2;
    public Text ergebnisText;
    bool bool1 = true;
    bool bool2 = true; 


    public void Addition()
    {
        float zahl1float = 0;
        float zahl2float = 0;
        float ergebnisFloat = 0; 
        string fehlerTxt = "Enter a valid number";

        try
        {
            zahl1float = float.Parse(zahl1.text);
            zahl1.image.color = Color.white;
            bool1 = true;
        }
        catch (System.Exception)
        {
            zahl1.image.color = Color.red;
            zahl1.text = fehlerTxt;
            bool1 = false; 
        }
        try
        {
            zahl2float = float.Parse(zahl2.text);
            zahl2.image.color = Color.white;
            bool2 = true;
        }
        catch (System.Exception)
        {
            zahl2.image.color = Color.red;
            zahl2.text = fehlerTxt;
            bool2 = false;
        }
       
        if(bool1 == true && bool2 == true)
        {
            ergebnisFloat = zahl1float + zahl2float;
            ergebnisText.text = ergebnisFloat.ToString();
        }
        else
        {
            ergebnisText.text = "Da kann ich leider nicht berechnen"; 
        }
    }
}
