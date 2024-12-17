using UnityEngine;

public class DelayedIntro : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject feature1; 

    void Start()
    {
        // Delay audio playback by 2 seconds
        Invoke("PlayAudio", 2f);
    }

    void PlayAudio()
    {
        audioSource.Play();
        Invoke("ActivateFeature", audioSource.clip.length);
    }
    
    void ActivateFeature()
    {
        if (feature1 != null)
        {
            feature1.SetActive(true);
        }
        else
        {
            Debug.LogError("feature1 is not assigned!");
        }
    }
}
