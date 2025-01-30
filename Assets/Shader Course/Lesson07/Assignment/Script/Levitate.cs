using UnityEngine;

public class Floating3D : MonoBehaviour
{
    [Header("Levitation Settings")]
    [Tooltip("Amplitude of the levitation movement (how high it moves).")]
    public float amplitude = 0.5f;

    [Tooltip("Speed of the levitation movement.")]
    public float frequency = 1f;

    [Header("Rotation Settings")]
    [Tooltip("Rotation speed around the X axis.")]
    public float rotationSpeedX = 10f;

    [Tooltip("Rotation speed around the Y axis.")]
    public float rotationSpeedY = 10f;

    [Tooltip("Rotation speed around the Z axis.")]
    public float rotationSpeedZ = 10f;

    // The initial position of the object
    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the levitation effect using a sine wave
        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);

        // Apply rotation to the object
        transform.Rotate(new Vector3(rotationSpeedX, rotationSpeedY, rotationSpeedZ) * Time.deltaTime);
    }
}
