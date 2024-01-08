using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public int cameraNr = 1;

    void Start()
    {
        if (cameraNr == 1)
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
        else if (cameraNr == 2)
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if(cameraNr == 1)
            {
                Camera1.SetActive(false); 
                Camera2.SetActive(true);
                cameraNr = 2;
            }
            else if(cameraNr == 2)
            {
                Camera1.SetActive(true);
                Camera2.SetActive(false);
                cameraNr = 1;
            }
        }
    }
}
