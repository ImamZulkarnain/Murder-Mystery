using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LogoAnimation : MonoBehaviour
{
    private Vector3 sizeChange, visibleSize;
    public MeshRenderer mesh;
    public TextMeshProUGUI passcode;

    // Start is called before the first frame update
    void Start()
    {
        // this.gameObject.SetActive(false);
        passcode = GetComponent<TextMeshProUGUI>();
        //mesh = GetComponent<MeshRenderer>();
        sizeChange = new Vector3(120f, 120f,120f);
        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (passcode.text.Equals("476"))
            mesh.enabled = true;
        if (mesh.enabled)
        {
            if (transform.localScale.z < 100)
            {
                transform.localScale += sizeChange * Time.deltaTime;
            }
            else
            {
                transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
            }
        }
    }
}
