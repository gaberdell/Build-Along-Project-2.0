using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            EventManager.PassAnInputIn(0.1f);
        }
        if (Input.GetKey("a"))
        {
            EventManager.PassAnInputIn(-0.1f);
        }
    }
}
