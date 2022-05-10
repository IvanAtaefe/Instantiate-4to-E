using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInput : MonoBehaviour
{
    public Text txtUsername;
    
    public void saludos(){
        Debug.Log("Hola " + txtUsername.text);
    }

    public void doble()
    {
        if (txtUsername.text != "")
        {
            Debug.Log(int.Parse(txtUsername.text) * 2);
        }
        else
        {
            Debug.Log("El campo no puede estar vacio");
        }
    }
}
