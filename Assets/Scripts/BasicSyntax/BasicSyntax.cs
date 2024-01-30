// These are similar to #include from c++ or import from python.
// In C# this is called the "using directive"
// (note there is a "using statement" but that's for say opening a file and has a similar pattern to an if statement)
// MAJOR thing to note is that all the files you code
using System.Collections;
using System.Collections.Generic;
using UnityEngine; //This is pretty important 

//Here we have a class it says public but classes can't be private this is there default
// |                    MonoBehavior gives you access to important Unity functions like Start(), Update(), Awake(), and transform
// V                        V
public class BasicSyntax : MonoBehaviour
{
    //Make variables like so
    private int number = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Here is where a lot of variables are gonna get set
        // From what I knowThe Unity engines GameObjects get only modified 
        // from here and Start, Update, etc. or functions called in them.
        Debug.Log("Hello World!");

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (number > 0)
        {
            number--;
        }
    }
}
