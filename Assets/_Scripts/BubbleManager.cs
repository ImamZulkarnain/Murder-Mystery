using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class BubbleManager : MonoBehaviour
{
    // Controls when each thought bubble is displayed
    private int index;
    private bool audioPlayed;
    private int numOfBubbles = 5;
    
    public GameObject sun;
    public GameObject boundary;
    private AudioSource currentAudio;
    
    public TextAppender textAppender;
    
    private string[] notes = {
        "Met Mr Green at 6:30",
        "Would do anything for his funding.",
        "Tried to silence Mr. Green",
        "Intention seems inconsistent."
    };

    // Start is called before the first frame update
    // The values are defaulted to the below to allow the update method to handle the initial assignment of the values.
    // index becomes 0 at start and audioPlayed becomes false
    void Start()
    {
        index = -1;
        audioPlayed = true;
        boundary.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (index == -1 || (!currentAudio.isPlaying && audioPlayed)) // if audio isn't playing but it has been played...
        {
            // move onto the next thought bubble
            index++;
            
            for (int i = 0; i < numOfBubbles; i++) transform.GetChild(i).gameObject.SetActive((i == index) ? true : false);

            // prepare the next audio
            audioPlayed = false;
            currentAudio = transform.GetChild(index).gameObject.GetComponent<AudioSource>();
        }
        else if (currentAudio.isPlaying && !audioPlayed) // if audio is playing but hasn't been updated to show that...
        {
            // indicate that the audio began playing
            audioPlayed = true;
            if (numOfBubbles != numOfBubbles-1)
                AppendNoteToNotepad(index);

            // turn off the light
            sun.SetActive(false);
            
            // turn on the boundary so the player can't move around freely
            boundary.SetActive(true);
        }
        else if (index == numOfBubbles) // once we reach the last bubble destroy everything for feature 1
        { 
            sun.SetActive(true);
            Destroy(transform.parent.gameObject);
        }
    }
    
    private void AppendNoteToNotepad(int currentIndex)
    {
        string suspectName = "";
        switch (currentIndex)
        {
            case 0: suspectName = "Brock"; break;
            case 1: suspectName = "Darby"; break;
            case 2: suspectName = "Hettie"; break;
            case 3: suspectName = "Blackwood"; break;
        }

        if (!string.IsNullOrEmpty(suspectName))
        {
            textAppender.AppendText(suspectName, notes[currentIndex]);
        }
    }
}
