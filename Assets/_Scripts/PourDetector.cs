using UnityEngine;
using TMPro;
using System.Collections;

public class PourDetector : MonoBehaviour
{
    public enum TubeType { Acidic, Alkaline }
    public TubeType tubeType;

    public TMP_Text pHDisplay;
    public Collider bucketCollider;
    private float pourRate = 0.5f; // The rate of pH change per second
    private float targetpH = 7.60f;
    private float tolerance = 0.01f; // Acceptable range around the target pH
    private static bool audioPlayed = false;
    public AudioSource audioSource; // Assign the audio source in the inspector

    private bool isPouring = false;
    private Coroutine checkStabilityCoroutine;

    void Update()
    {
        if (!audioPlayed)
        {
            DetectPour();
        }
    }

    void DetectPour()
    {
        // Check if the test tube is tilted more than 45 degrees
        bool isTilted = Vector3.Angle(transform.up, Vector3.up) > 45f;

        // Check if the test tube is directly above the bucket
        bool isAboveBucket = IsAboveBucket();

        if (isTilted && isAboveBucket)
        {
            isPouring = true;
        }
        else
        {
            isPouring = false;
        }

        if (isPouring)
        {
            AdjustpH();
        }
    }

    bool IsAboveBucket()
    {
        // Get the bounds of the bucket's collider
        Bounds bucketBounds = bucketCollider.bounds;

        // Check if the test tube's position is within the X and Z bounds of the bucket
        bool withinX = transform.position.x >= bucketBounds.min.x && transform.position.x <= bucketBounds.max.x;
        bool withinZ = transform.position.z >= bucketBounds.min.z && transform.position.z <= bucketBounds.max.z;

        // Check if the test tube's Y position is above the bucket's top surface
        bool aboveY = transform.position.y > bucketBounds.max.y;

        return withinX && withinZ && aboveY;
    }

    void AdjustpH()
    {
        float currentpH;

        // Try parsing the current pH value
        if (float.TryParse(pHDisplay.text, out currentpH))
        {
            if (tubeType == TubeType.Acidic)
            {
                currentpH -= pourRate * Time.deltaTime; // Decrease pH continuously
            }
            else if (tubeType == TubeType.Alkaline)
            {
                currentpH += pourRate * Time.deltaTime; // Increase pH continuously
            }

            currentpH = Mathf.Clamp(currentpH, 0f, 14f); // Clamp between 0 and 14

            pHDisplay.text = currentpH.ToString("F2"); // Display with two decimal places

            CheckForTargetpH(currentpH);
        }
        else
        {
            Debug.LogError("Failed to parse pH value from TMP.");
        }
    }

    void CheckForTargetpH(float currentpH)
    {
        if (Mathf.Abs(currentpH - targetpH) <= tolerance)
        {
            if (checkStabilityCoroutine == null)
            {
                checkStabilityCoroutine = StartCoroutine(WaitAndPlayAudio());
            }
        }
        else
        {
            if (checkStabilityCoroutine != null)
            {
                StopCoroutine(checkStabilityCoroutine);
                checkStabilityCoroutine = null;
            }
        }
    }

    IEnumerator WaitAndPlayAudio()
    {
        yield return new WaitForSeconds(1f); // Wait for 1 second to ensure stability

        if (audioSource != null && !audioSource.isPlaying)
        {
            audioPlayed = true;
            audioSource.Play();
            Debug.Log("Target pH reached. Playing audio.");
        }

        checkStabilityCoroutine = null; // Reset the coroutine
    }
}
