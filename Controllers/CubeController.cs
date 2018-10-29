using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            PickupTracker pickupTracker = Object.FindObjectOfType<PickupTracker>();
            pickupTracker.current += 1;
            LostPickupTracker lostPickupTracker = Object.FindObjectOfType<LostPickupTracker>();
            lostPickupTracker.current += 1;
            Destroy(this.gameObject);
        }
    }
}
