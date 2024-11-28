using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasscodePuzzle : MonoBehaviour
{

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void floatOnTouch()
    {
        transform.Rotate(0, 0, 1);
        transform.Translate(new Vector3(0, 0, 0.22f) * Time.deltaTime);
    }
}
