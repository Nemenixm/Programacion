using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedX;
    public float speedY;
    public float speedZ;
    public float speedRotation;
    public float speedRotationSphere;


    private float rotationAngle=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Movimiento en 2 ejes
        playerTransform.Translate(0, Time.deltaTime * speedY, Time.deltaTime * speedZ);
        
        //Movimiento en 2 ejes
        //Podemos elegir entre estas  formas
        playerTransform.Translate(speedX * Time.deltaTime, 0, 0);
        playerTransform.Translate(Vector2.right * Time.deltaTime * speedX);
        playerTransform.Translate(Vector3.forward * Time.deltaTime * speedZ);
        
        //Para rotaciones
        //Rotacion en 1 eje
        playerTransform.Rotate(speedRotation * Time.deltaTime,0,0);
        playerTransform.Rotate(Vector3.right * speedRotation * Time.deltaTime);

        //Rotate Around
        //Rota alrededor de la posicion del player en el eje Z
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward,rotationAngle * Time.deltaTime * speedRotationSphere);
        rotationAngle++;
    }
}
