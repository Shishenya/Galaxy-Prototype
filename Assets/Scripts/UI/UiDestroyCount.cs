using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiDestroyCount : MonoBehaviour
{
    public Text textCount;
    const string nameTextCount = "textDestroy";

    private void Start()
    {
        textCount = GameObject.Find(nameTextCount).gameObject.GetComponent<Text>();
    }

    public void UpdateCount()
    {
        int curruntCount = Int32.Parse(textCount.text);
        curruntCount++;
        textCount.text = curruntCount.ToString();
    }
}
