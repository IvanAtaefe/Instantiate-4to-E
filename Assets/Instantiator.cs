using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public Text txtCloneAmount;
    public GameObject objectToClone;
    GameObject clon;

    public void MultiInstantiate()
    {
        if (txtCloneAmount.text != "")
        {
            for (int i = 0; i < int.Parse(txtCloneAmount.text); i++)
            {
            clon = Instantiate(objectToClone);
                Destroy(clon, 2);
            }
        }
        else
        {
            Debug.Log("El campo no puede estar vacio");
        }
    }
}
