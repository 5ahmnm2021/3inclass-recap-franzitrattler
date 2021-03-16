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


    public void Addition()
    {
        try
        {
            Zahl1float = float.Parse(Zahl1.text);
            Zahl1.image.color = new Color32(255, 255, 255, 255); 
        }
        catch (System.Exception)
        {
            Zahl1.image.color = new Color32(255, 0, 0, 255);
            Zahl1.text = "Enter a valid number"; 
        }
        try
        {
            Zahl2float = float.Parse(Zahl2.text);
            Zahl2.image.color = new Color32(255, 255, 255, 255);
        }
        catch (System.Exception)
        {
            Zahl2.image.color = new Color32(255, 0, 0, 255);
            Zahl2.text = "Enter a valid number";
        }
       

        //Additon
      //  int if1Int = int.Parse(Zahl1.text);
      //  int if2Int = int.Parse(Zahl2.text);
        
        float ergebnisInt = Zahl1float + Zahl2float;
        ergebnis.text = ergebnisInt.ToString();
    }
}
