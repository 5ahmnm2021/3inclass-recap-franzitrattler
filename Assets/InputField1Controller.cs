using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField1Controller : MonoBehaviour
{
    public InputField if1String;

    public void InputFieldCheck()
    {
        //String check 1
        string strnInput = if1String.text;

        int result = 0;

        if (int.TryParse(strnInput, out result))
        {

        }
        else
        {
            if1String.text = "Enter a valid number!";
            if1String.image.color = Color.red;
        }
    }

}
