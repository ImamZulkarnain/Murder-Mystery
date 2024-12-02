using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoAnimation : MonoBehaviour
{
    private Vector3 sizeChange, visibleSize;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        sizeChange = new Vector3(10f, 10f,10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.z < 100)
        {
            transform.localScale += sizeChange * Time.deltaTime;
        }else
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}
