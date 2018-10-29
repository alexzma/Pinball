using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    private Text text;
    public float time;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        time = 0;
	}
	
    void ChangeText (string newtext) {
        text.text = newtext;
    }

	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        ChangeText(time.ToString());
	}
}
