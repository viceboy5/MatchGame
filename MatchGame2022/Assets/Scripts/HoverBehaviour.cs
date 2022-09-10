using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HoverBehaviour : MonoBehaviour
{
    public UnityEvent HoverEvent, NoHoverEvent;
    
    private void OnMouseOver()
    {
        HoverEvent.Invoke();
    }

    private void OnMouseExit()
    {
        NoHoverEvent.Invoke();
    }
}
