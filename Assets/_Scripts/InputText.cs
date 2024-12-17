using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public TextMeshProUGUI code;
    public GameObject screen;
    public GameObject email;
    public BuzzerButton buzzerButton;
    //public Button button;

    // Start is called before the first frame update
    void Start()
    {
        code = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(code.text.Length == 3)
        {
            if(code.text.Equals("476"))
            {
                email.SetActive(true);
                buzzerButton.setEmailOpened();
                screen.SetActive(false);
            }
            else
            {
                code.text = "";
            }
        }
    }

    public void ButtonOnPressed(string text)
    {
        code.text = code.text + text;
    }
}
