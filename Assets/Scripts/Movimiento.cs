using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Vector3 playerPosition;
    public float rotation = 0;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = transform.position + new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.localScale += new Vector3(0.1f, 0, 0);
        }

        transform.eulerAngles += new Vector3(0, rotation, 0);

    }
}
