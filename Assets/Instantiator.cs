using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtCloneAmount;
    public GameObject objectToClone;

    public void MultiInstantiate()
    {
        int counter = 0;
        if (txtCloneAmount.text != "")
        {
            while (counter < int.Parse(txtCloneAmount.text)) ;
            {
                Instantiate(objectToClone);
                counter++;
            }
        }
        else
        {
            Debug.Log("El campo no puede estar vacio");
        }
    }
}
