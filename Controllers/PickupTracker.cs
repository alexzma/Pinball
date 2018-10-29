using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupTracker : MonoBehaviour
{

    private Text m_text;
    private GameObject[] pickups;
    public int current;
    public int total;
    public bool lost;

    // Use this for initialization
    void Start()
    {
        m_text = GetComponent<Text>();
        pickups = GameObject.FindGameObjectsWithTag("Pickup");
        total = pickups.Length;
        lost = false;
    }
    void changeText(string text)
    {
        m_text.text = text;
    }
    // Update is called once per frame
    void Update()
    {
        if (current == total)
        {
            changeText("You Won!");
            TimeTracker timeTracker = Object.FindObjectOfType<TimeTracker>();
            timeTracker.won = true;
            TimerController timer = Object.FindObjectOfType<TimerController>();
            timeTracker.time = timer.time;
        }
        else if (lost)
        {
            changeText("You lost!");
            TimeTracker timeTracker = Object.FindObjectOfType<TimeTracker>();
            timeTracker.lost = true;
            TimerController timer = Object.FindObjectOfType<TimerController>();
            timeTracker.time = timer.time;
            LostPickupTracker lostPickupTracker = Object.FindObjectOfType<LostPickupTracker>();
            lostPickupTracker.current = current;
            lostPickupTracker.total = total;
            lostPickupTracker.lost = true;
        }
        else
            changeText("Pickups Collected: " + current + '/' + total);
    }
}
