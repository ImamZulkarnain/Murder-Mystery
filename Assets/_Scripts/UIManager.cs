using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public CanvasGroup uiCanvasGroup; // Assign in the Inspector

    // Hide the UI
    public void HideUI()
    {
        uiCanvasGroup.alpha = 0f;          // Make it fully transparent
        uiCanvasGroup.interactable = false; // Disable interaction
        uiCanvasGroup.blocksRaycasts = false; // Prevent it from blocking clicks
    }

    // Show the UI
    public void ShowUI()
    {
        uiCanvasGroup.alpha = 1f;          // Make it fully visible
        uiCanvasGroup.interactable = true; // Enable interaction
        uiCanvasGroup.blocksRaycasts = true; // Allow it to block clicks
    }
}