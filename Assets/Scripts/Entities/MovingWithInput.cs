using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWithInput : MonoBehaviour
{

    private Vector3 moveAmountVector = new Vector3(0f, 0f, 0f);

    void OnEnable()
    {
        EventManager.onInput += Move;
    }

    void OnDisable()
    {
        EventManager.onInput -= Move;
    }

    void Move(float moveAmount)
    {
        moveAmountVector.x = moveAmount;
        //Write out the actually code you sussy bakas
        Debug.Log("mogus");
    }

}

