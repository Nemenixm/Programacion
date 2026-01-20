using Unity.VisualScripting;
using UnityEngine;

public class AdvancedVector3 : MonoBehaviour
{
    public Transform finalTransform;
    public Transform initialTransform;
    public float speed=1;

    private Vector3 _directionVector;
    void Start()
    {
        _directionVector = finalTransform.position - initialTransform.position;
    }

    
    void Update()
    {
        //Calculo del vector direccion
        _directionVector =finalTransform.position - initialTransform.position;

        //Convierte el vector en unitario
        //Normalizamos el Vector para que siempre se mueva a la misma velocidad, independientemente de la distancia.
        //Asi podemos poner un sistema de persecución con la misma velocidad "speed"
        //Si quisieramos tener magnitud en base a distancia, solo tendríamos que eliminar la siguiente línea
        _directionVector.Normalize();

        //Dibujamos el Vector
        //Vector3.zero es lo mismo que "new Vector3(0,0,0)"
        //Debug.DrawLine(Vector3.zero, _directionVector);
        Debug.DrawRay(initialTransform.position, _directionVector *speed);

        //Translate
        //Hacemos que se desplace hasta ese punto, un sistema de persecucion
        initialTransform.Translate(_directionVector * Time.deltaTime * speed);

        //Magnitud
        //Muestra la magnitud del Vector3 a medida que se va acercando
        print("Magnitude: " + _directionVector.magnitude *speed);

        //Distance
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance: " + distance);

        //Efecto para que a partir de que la distancia sea menos de 10 y mayor de 20 vaya invirtiendo hacia donde se mueve
        if(distance<10 || distance > 20)
        {
            speed *= -1;
        }
    }
}
