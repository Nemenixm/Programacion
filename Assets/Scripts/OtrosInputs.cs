using UnityEngine;

public class OtrosInputs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Input.touchCount: Cantidad de dedos en la pantalla
       // Input.GetTouch(0): Nos da el toque principal
       // TouchPhase.Began : Down, cuando iniciamos el toque
       // TouchPhase.Ended : Up, cuando dejamos de tocar
       // TouchPhase.Canceled : Si se cancela el toque
       // TouchPhase.Moved : Si está en movimiento
       // TouchPhase.Stationary : Toque en un punto sin movimiento
    }
}
