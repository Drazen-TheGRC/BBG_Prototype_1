using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed; // Speed of the object
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // Move the object forward at the specified speed
    }
}
