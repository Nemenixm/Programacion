using UnityEngine;

public class InputClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Key Down Up: Enter
        if (Input.GetKeyUp(KeyCode.Return))
        {
            print("Se ha SOLTADO Enter.");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Se ha PULSADO Enter.");
        }
        if (Input.GetKey(KeyCode.Return))
        {
            print("Se esta PULSANDO Enter.");
        }
        
        //Other keys
        if (Input.GetKeyUp(KeyCode.A))
        {
            print("Se ha SOLTADO A.");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            print("Se ha SOLTADO left.");
        }
        if (Input.GetKeyUp(KeyCode.F1))
        {
            print("Se ha SOLTADO F1.");
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            print("Se ha SOLTADO Escape.");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Se ha SOLTADO espacio.");
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            print("Se ha SOLTADO Alt izq.");
        }
       
    }
}
