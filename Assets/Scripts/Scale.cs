using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalling : MonoBehaviour
{
    public float scale = .01f;
    private Vector3 defaultSize;

    // Start is called before the first frame update
    void Start()
    {
        defaultSize = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //Increase size
        if(Input.GetKey("x"))
        {
            transform.localScale += new Vector3(scale, scale, scale);
        }

        //Decrease size
        if(Input.GetKey("z"))
        {
            transform.localScale -= new Vector3(scale, scale, scale);
        }

        if (Input.GetKey("c"))
        {
            transform.localScale = defaultSize;
        }
    }
}
