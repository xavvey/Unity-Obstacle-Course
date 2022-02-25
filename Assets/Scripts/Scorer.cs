using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int amountOfHits = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag != "Hit")
        {
            amountOfHits++;
            Debug.Log("Hit stuff this much: " + amountOfHits); 
        }
    }
}
