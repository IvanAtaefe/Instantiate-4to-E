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
        if (txtCloneAmount.text != "")
        {
            for (int i = 0; i < int.Parse(txtCloneAmount.text); i++)
            {
            Instantiate(objectToClone);
            }
        }
        else
        {
            Debug.Log("El campo no puede estar vacio");
        }
    }
}
