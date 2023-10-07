using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonToggleObj : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject objectToToggle;
    public Button toggleButton;

    private bool isObjectActive = true;
    // Start is called before the first frame update
    void Start()
    {
        toggleButton.onClick.AddListener(ToggleObject);
    }

    public void ToggleObject()
    {
        isObjectActive = !isObjectActive;
        objectToToggle.SetActive(isObjectActive);
    }
}
