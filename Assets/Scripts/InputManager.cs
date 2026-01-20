using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Transform cubeTransform;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Dibuja una linea según pulsemos la W (hacia arriba) blue, S (hacia abajo) blue, A (hacia la izquierda) red, D (hacia la derecha) red
        Debug.DrawRay(cubeTransform.position, Vector3.right*Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, Vector3.forward*Input.GetAxis("Vetical"), Color.blue);
        print("Horizontal: " + Input.GetAxis("Horizontal"));
    }
}
