using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Additon : MonoBehaviour
{

    public InputField if1String;
    public InputField if2String;
    public Text ergebnis;


    public void Addition()
    {
       
        //String check 1
        string strnInput = if1String.text;

        int result = 0;

        if(int.TryParse(strnInput, out result))
        {

        }
        else
        {
            if1String.text = "Enter a valid number!";
            if1String.image.color = Color.red; 
        }


        //String check 2
        string strnInput2 = if1String.text;

        int result2 = 0;

        if (int.TryParse(strnInput2, out result2))
        {
           
        }
        else
        {
            if2String.text = "Enter a valid number!";
            if2String.image.color = Color.red;
        }

        //Additon
        int if1Int = int.Parse(if1String.text);
        int if2Int = int.Parse(if2String.text);
        int ergebnisInt = if1Int + if2Int;
        ergebnis.text = ergebnisInt.ToString();
    }
}
