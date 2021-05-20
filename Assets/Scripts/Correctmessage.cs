using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Correctmessage : MonoBehaviour
{
    public TextMeshProUGUI contentField;

    public void SetText(string text)
    {
        contentField.text = text;
    }

}
