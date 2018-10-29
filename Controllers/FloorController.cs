using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour {

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Ball")){
            PickupTracker pickupTracker = Object.FindObjectOfType<PickupTracker>();
            pickupTracker.lost = true;
        }
    }

}
