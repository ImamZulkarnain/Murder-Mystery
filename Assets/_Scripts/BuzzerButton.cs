using UnityEngine;

public class BuzzerButton : MonoBehaviour
{
    public AudioSource audioSourceBefore;
   
    public GameObject feature3; // Reference to the Feature-3 GameObject
    public GameObject feature4;
    public GameObject intel;
    public bool emailOpened = false;

    public void PlayBuzzerSound()
    {
        if (emailOpened == false)
        {
            if (audioSourceBefore != null && !audioSourceBefore.isPlaying)
            {
                audioSourceBefore.Play();
                ActivateFeature3();
            }
        }
        else
        {
            ActivateIntel();
        }

    }

    public void ActivateIntel()
    {
        if (intel != null && !intel.activeSelf)
        {
            intel.SetActive(true);
        }
    }

    private void ActivateFeature3()
    {
        if (feature3 != null && !feature3.activeSelf)
        {
            feature3.SetActive(true);
            Debug.Log("Feature-3 has been activated.");
        }
    }

    private void ActivateFeature4()
    {
        if (feature4 != null && !feature4.activeSelf)
        {
            feature4.SetActive(true);
            Debug.Log("Feature-4 has been activated.");
        }
    }

    public void setEmailOpened()
    {
        emailOpened = true;
    }
}