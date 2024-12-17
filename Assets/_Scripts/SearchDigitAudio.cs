using UnityEngine;

public class SearchDigitAudio : MonoBehaviour
{
    public AudioSource audioSource;
    
    public void PlaySearchDigitAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}