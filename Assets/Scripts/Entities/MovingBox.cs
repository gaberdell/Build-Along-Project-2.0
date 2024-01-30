using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    private Vector3 addAmount = new Vector3(0.1f, 0f, 0f);

    //No need for start so don't include it as it can leave resources
    //For why this doesn't go away when pseudo compilied...
    //My main guess for this is C# includes reflection (you can make your code write code)
    //So maybe it has something to do with that

    // Update is called once per frame
    void Update()
    {
        //transform can only be referenced in Start, Update, etc.
        //transform is a reference to whatever object the script is attached to.
        transform.position += addAmount;
    }
}
