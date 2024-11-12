using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MaintainPlayerHeight : MonoBehaviour
{
    public float targetHeight = 1.2f;
    public float crouchThreshold = 1.0f; // Set threshold for detecting crouching
    private CharacterController characterController;
    private Transform cameraTransform;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.transform; // Assumes the main camera is the VR camera
    }

    void Update()
    {
        if (characterController && cameraTransform)
        {
            // Check if player is crouching (camera height below threshold)
            if (cameraTransform.localPosition.y < crouchThreshold)
            {
                // Allow bending down without forcing the height
                characterController.height = cameraTransform.localPosition.y;
                characterController.center = new Vector3(0, characterController.height / 2, 0);
            }
            else
            {
                // Maintain standard height if not crouching
                characterController.height = targetHeight;
                characterController.center = new Vector3(0, targetHeight / 2, 0);
            }
        }
    }
}