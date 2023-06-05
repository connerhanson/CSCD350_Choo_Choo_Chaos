using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ButtonHandle : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    public static bool buttonPressed;

        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }
     void IPointerUpHandler.OnPointerUp(PointerEventData eventData) {
        buttonPressed = false;
    }
}

