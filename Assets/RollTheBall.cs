using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollTheBall : MonoBehaviour
{
    public float xforce = 5.0f;
    public float yforce = 5.0f;
    public float zforce = 5.0f;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = x - xforce;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x = x + xforce;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z = z + zforce;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z = z - zforce;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            y = y + yforce;
        }
        if (Input.GetKey(KeyCode.V))
        {
            y -= yforce;
        }
        GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
