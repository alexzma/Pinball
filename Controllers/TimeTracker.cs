using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour {

    private Text m_text;
    public float time;
    public bool lost;
    public bool won;
    public bool hasTime;

	// Use this for initialization
	void Start () {
        m_text = GetComponent<Text>();
        time = 0;
        lost = false;
        won = false;
        hasTime = false;
	}
	
    void ChangeText(string text){
        m_text.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasTime)
        {
            if (lost)
            {
                ChangeText("Time: " + time);
                hasTime = true;
            }
            if (won)
            {
                ChangeText("Time: " + time);
                hasTime = true;
            }
        }
	}
}
