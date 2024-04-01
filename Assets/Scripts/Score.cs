using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount;
    private Text text;

    void Start()
    {   
        text = GetComponent<Text>();
        pinCount = 0;
    }

    // Update is called once per frame
void Update()
{
    text.text = pinCount.ToString();
}

}
