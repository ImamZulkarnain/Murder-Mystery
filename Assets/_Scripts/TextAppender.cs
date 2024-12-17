using TMPro;
using UnityEngine;

public class TextAppender : MonoBehaviour
{
    // References to the TextMeshPro components
    public TMP_Text darbyText;
    public TMP_Text hettieText;
    public TMP_Text blackwoodText;
    public TMP_Text brockText;

    // Append text to the specified TextMeshPro by name
    public void AppendText(string textMeshProName, string textToAppend)
    {
        switch (textMeshProName)
        {
            case "Darby":
                darbyText.text += "\n" + textToAppend;
                break;
            case "Hettie":
                hettieText.text += "\n" + textToAppend;
                break;
            case "Blackwood":
                blackwoodText.text += "\n" + textToAppend;
                break;
            case "Brock":
                brockText.text += "\n" + textToAppend;
                break;
            default:
                Debug.LogWarning($"No TextMeshPro found with the name: {textMeshProName}");
                break;
        }
    }
}