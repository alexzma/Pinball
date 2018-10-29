using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LostPickupTracker : MonoBehaviour
{

    private Text m_text;
    public bool lost;
    public int current;
    public int total;

    // Use this for initialization
    void Start()
    {
        m_text = GetComponent<Text>();
        lost = false;
        current = 0;
        total = 0;
    }
    void changeText(string text)
    {
        m_text.text = text;
    }
    // Update is called once per frame
    void Update()
    {
        if (lost)
            changeText("Pickups Collected: " + current + '/' + total);

    }
}
