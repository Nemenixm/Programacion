using UnityEngine;

public class Espacio2D : MonoBehaviour
{
    public Transform playerTransform;
    public Vector2 punto1 = new Vector2(10, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Pos X: " + punto1.x);
        print("Pos Y: " + punto1.y);

        playerTransform.position = punto1;
    }

    // Update is called once per frame
    void Update()
    {
        playerTransform.position = punto1;
        punto1 += Vector2.right * Time.deltaTime;
    }
}
