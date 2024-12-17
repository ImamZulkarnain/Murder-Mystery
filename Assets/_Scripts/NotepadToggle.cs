using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NotepadToggle : MonoBehaviour
{
    public GameObject notepadCanvas; // Assign your notepad canvas here
    public InputActionReference toggleAction; // Reference to the input action for toggling

    public void Start()
    {
        notepadCanvas.SetActive(false);
    }

    private void OnEnable()
    {
        // Enable the action
        toggleAction.action.Enable();
        toggleAction.action.performed += OnTogglePerformed;
    }

    private void OnDisable()
    {
        // Disable the action
        toggleAction.action.Disable();
        toggleAction.action.performed -= OnTogglePerformed;
    }

    private void OnTogglePerformed(InputAction.CallbackContext context)
    {
        // Toggle the notepad canvas visibility
        notepadCanvas.SetActive(!notepadCanvas.activeSelf);
    }
}