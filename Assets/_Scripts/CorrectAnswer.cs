using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject intel;
    public GameObject feature4;

    public void PlayAudioSource()
    {
        audioSource.Play();
        intel.SetActive(false);
        feature4.SetActive(true);
    }
  
}
