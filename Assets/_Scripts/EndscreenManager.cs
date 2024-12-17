using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndscreenManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text resultsText;          // Display the result message
    public GameObject feedbackPanel;      // Panel to show feedback
    public Button[] suspectButtons;       // Array of buttons for each suspect

    [Header("Correct Answer")]
    public string correctSuspectName;     // The name of the correct suspect

    // Called when a suspect button is clicked
    public void OnSuspectSelected(string selectedSuspect)
    {
        feedbackPanel.SetActive(true);

        if (selectedSuspect == correctSuspectName)
        {
            resultsText.text = "🎉 Brilliant deduction, detective! The killer is indeed " + selectedSuspect + ". Case closed!";
        }
        else
        {
            resultsText.text = "❌ Oops! That wasn’t the killer. The real culprit got away. Better luck next time!";
        }

        // Disable all suspect buttons after selection
        foreach (Button button in suspectButtons)
        {
            button.interactable = false;
        }
    }

    // Method to restart the game
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Method to exit the game
    public void ExitGame()
    {
        Application.Quit();
    }
}