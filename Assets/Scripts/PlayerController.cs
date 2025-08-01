using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f; // Speed of the vehicle
    private float TurnSpeed = 50.0f; // Speed of rotation
    private float horizontalInput; // Input for horizontal movement
    private float verticalInput; // Input for vertical movement

    // Cameras
    public Camera mainCamera; // Reference to the main camera
    public Camera hoodCamera; // Reference to the secondary camera
    private KeyCode toggleCameraKey = KeyCode.F; // Key to toggle cameras

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (A/D keys or Left/Right arrows)
        verticalInput = Input.GetAxis("Vertical"); // Get vertical input (W/S keys or Up/Down arrows)
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Rotate the vehicle based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * verticalInput * horizontalInput  ); // Adjust rotation speed as needed

        // Toggle camera view when the toggleCameraKey is pressed
        if (Input.GetKeyDown(toggleCameraKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled; 
        }
    }
}
