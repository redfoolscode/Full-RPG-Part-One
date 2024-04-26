using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour
{
    public float speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation == Quaternion.Euler(new Vector3(0, 0, 270)))
        {
            transform.Translate((transform.up * speed * Time.deltaTime));
        }
        if (transform.rotation == Quaternion.Euler(new Vector3(0, 0, 90)))
        {
            transform.Translate((transform.up * -speed * Time.deltaTime));
        }
        if (transform.rotation == Quaternion.Euler(new Vector3(0, 0, 0)))
        {
            transform.Translate((transform.right * speed * Time.deltaTime));
        }
        if (transform.rotation == Quaternion.Euler(new Vector3(0, 0, 180)))
        {
            transform.Translate((transform.right * -speed * Time.deltaTime));
        }
    }
}
