using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Additon : MonoBehaviour
{

    public InputField Zahl1;
    public InputField Zahl2;
    public Text ergebnis;

    public float Zahl1float;
    public float Zahl2float;

    public bool bool1 = true;
    public bool bool2 = true; 


    public void Addition()
    {
        try
        {
            Zahl1float = float.Parse(Zahl1.text);
            Zahl1.image.color = new Color32(255, 255, 255, 255);
            bool1 = true;
        }
        catch (System.Exception)
        {
            Zahl1.image.color = new Color32(255, 0, 0, 255);
            Zahl1.text = "Enter a valid number";
            bool1 = false; 
        }
        try
        {
            Zahl2float = float.Parse(Zahl2.text);
            Zahl2.image.color = new Color32(255, 255, 255, 255);
            bool2 = true;
        }
        catch (System.Exception)
        {
            Zahl2.image.color = new Color32(255, 0, 0, 255);
            Zahl2.text = "Enter a valid number";
            bool2 = false;
        }
       
        if(bool1 == true && bool2 == true)
        {
            float ergebnisInt = Zahl1float + Zahl2float;
            ergebnis.text = ergebnisInt.ToString();
        }
        else
        {
            ergebnis.text = "Da kann ich leider nicht berechnen"; 
        }
    }
}
