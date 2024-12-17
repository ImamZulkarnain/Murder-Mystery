using UnityEngine;

public class NotepadManager : MonoBehaviour
{
    public Transform cameraTransform; // The camera transform
    public Vector3 offset = new Vector3(0, -0.2f, 0.5f); // Offset relative to the camera
    public Vector3 rotationOffset = new Vector3(10f, 0f, 0f);

    void Start()
    {
        // Get the camera if not explicitly assigned
        if (cameraTransform == null)
        {
            cameraTransform = Camera.main.transform;
        }
    }

    void Update()
    {
        if (cameraTransform != null)
        {
            // Position the notepad in front of the camera
            transform.position = cameraTransform.position + cameraTransform.forward * (offset.z + 1f) +
                                 cameraTransform.up * offset.y + cameraTransform.right * offset.x;

            // Make the notepad face the camera
            Quaternion lookRotation = Quaternion.LookRotation(cameraTransform.forward, Vector3.up);
            transform.rotation = lookRotation * Quaternion.Euler(rotationOffset + new Vector3(-15f, 180f, 0f));
          
        }
    }
}