using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTwoBox : MonoBehaviour
{
    //Here is one way to grab the Moving Box
    [SerializeField] // This is a thing from Unity adding it ABOVE a variable causes it to show up in the editor
    private GameObject anotherBox;

    private Transform anotherTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Here is how you can get a component from another game object

        anotherTransform = anotherBox.GetComponent<Transform>();

        //Additionally here you can use other functions to get game objects

        //NOTE GRABBING GAME OBJECTS AND COMPONENTS IS SUPER SLOWWWW
        //SO ONLY DO IT WHEN YOU NEED TOO!

            //Would find the game object Bob
        //GameObject testGameObject = GameObject.Find("Bob");


        //Finally I would like to mention that GameObjects can always grab a transform
        //so doing anotherBox.transform would work
        //I believe though under the hood it is still .GetComponent so it is still SLOWW
    }

    // Update is called once per frame
    void Update()
    {
        //Ok now its your turn make me proud and move these two boxes!
    }

    //P.S. you may have noticed the <> on GetComponent. These are called generics
    //They let a function have a generic type it can use.
    //It's a bit similar to Templates but a bit easier to code, but less flexible.
    //Some examples here -> https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/differences-between-cpp-templates-and-csharp-generics
}
