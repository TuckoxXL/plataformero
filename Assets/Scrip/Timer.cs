using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public Text textoTimer;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0");
    }
}
