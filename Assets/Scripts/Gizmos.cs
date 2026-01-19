using UnityEngine;

public class Gizmos : MonoBehaviour
{
    public Vector2 point1;
    public Vector2 point2;
    public Transform cubo;
    
    void Start()
    {
        cubo.position = new Vector3(5,transform.position.y, transform.position.z);

        //Si la posición que indiquemos tiene decimales, tendremos que poner la f para indicarle que es un float
        transform.localScale = new Vector3(1, 0.1f, 0.1f);
        
    }

    void Update()
    {   
        //Draw Line
        //Dibuja una linea de punto1 a punto2
        Debug.DrawLine(point1, point2);
        //Se crea nuevos vector2 y se dibuja una líne entre estas dos nuevas líneas, en las cordenadas dadas
                    //Creas otro Vector directamente
        Debug.DrawLine(new Vector2(0,0), new Vector2(2,2));
        //También se puede añadir color a la línea
        Debug.DrawLine(point1, point2, Color.red);

        //Draw Ray
        //Local Axis of the cube
        Debug.DrawRay(point1, point2, Color.red);
        Debug.DrawRay(transform.position, transform.up, Color.green);
        Debug.DrawRay(transform.position, transform.right, Color.blue);
        Debug.DrawRay(transform.position, transform.forward, Color.yellow);
    }
}
