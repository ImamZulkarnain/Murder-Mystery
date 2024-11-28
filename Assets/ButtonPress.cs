using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Torch"))
            this.gameObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Torch"))
            this.gameObject.SetActive(false);
    }
}
