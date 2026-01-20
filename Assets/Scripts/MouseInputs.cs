using JetBrains.Annotations;
using UnityEngine;

public class MouseInputs : MonoBehaviour
{
    public Transform _target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mouse / Touch
        if(Input.GetMouseButtonUp(0)){}
        if(Input.GetMouseButtonUp(1)){}
        if(Input.GetMouseButtonUp(2)){}

        //Mouse Position
        print("Mouse Y: " + Input.mousePosition.x + " / Mouse Y: "+ Input.mousePosition.y);

        //Hacemo que un objeto se mueva por donde se mueva el raton
        _target.position = Input.mousePosition;
        
    }
}
