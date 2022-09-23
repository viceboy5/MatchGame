using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");
        var tempObj = other.GetComponent<ColorMatchBehaviour>();
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
            Debug.Log("Match");
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
            Debug.Log("No Match");
        }
    }
}
