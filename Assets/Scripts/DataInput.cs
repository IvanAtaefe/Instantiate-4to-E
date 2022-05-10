using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInput : MonoBehaviour
{
    public Text txtUsername;
    
    public void saludos (){
        Debug.Log("Hola " + txtUsername.text);
    }
}
