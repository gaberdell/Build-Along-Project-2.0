using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //Event Jumpscare :o

    //Delegates are uhm things basically
    public delegate void OnInput(float inputDirection);

    //Then you pass it in an event idk what is different from a delegate
    //They can be subscribed to using += and the name of a function
    //Idk google prolly helps
    public static event OnInput onInput;

    // Check to see if they exsist / what will the public be interacting with
    public static void PassAnInputIn(float inputDirection)
    {
        if (onInput != null)
        {
            onInput(inputDirection);
        }
    }
}
