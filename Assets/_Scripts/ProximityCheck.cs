using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityCheck : MonoBehaviour
{
    public GameObject hint;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Torch"))
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            hint.SetActive(true);
        }
            
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Torch"))
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
}
