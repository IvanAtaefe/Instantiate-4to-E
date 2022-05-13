using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public Vector3 playerPostition;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = transform.position + new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, 1, 0);
        transform.localScale += new Vector3(0.1f, 0, 0),
    }
}
