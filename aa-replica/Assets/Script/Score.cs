using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount;

    public TextMeshProUGUI textMesh;

    private void Start()
    {
        pinCount = 0;
    }

    private void Update()
    {
        textMesh.SetText(pinCount.ToString());
    }
}
