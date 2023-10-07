using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonToggleObj : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject objectToToggle;

    private bool isObjectActive = true;



    public void OnPointerClick(PointerEventData eventData)
    {
        isObjectActive = !isObjectActive;
        objectToToggle.SetActive(isObjectActive);
    }

}
