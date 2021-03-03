using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{

    public enum EName
    {
        Jen,
        Marc,
        Jose,
        Jessica
    }

    public EName name = EName.Jen; 

    public string str_name;


    // Start is called before the first frame update
    void Start()
    {
        switch(name)
        {
            case EName.Jen: Debug.Log("My name is Jen"); break;
            case EName.Marc: Debug.Log("My name is Marc"); break;
            case EName.Jose: Debug.Log("My name is Jose"); break;
            case EName.Jessica: Debug.Log("My name is Jessica"); break;
            default: Debug.Log("My name is something"); break;
            
        }


        //string name = "Marc";
       // if (name == "James")
      //  {
       //     Debug.Log("My name is James");
     //   }
     //   else if (name == "Marc")
      //  {
     //       Debug.Log("My name is Marc");
      //  }
      //  else
     //   {
       //     Debug.Log("I don't recognise that name");
     //   }

    //    switch(name)
     //   {
     //       case "James": Debug.Log("My name is James"); break;
      //      case "Marc": Debug.Log("My name is Marc"); break;
     //       default: Debug.Log("I don't recognise that name"); break;
     //   }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
