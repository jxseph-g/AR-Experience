using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuItem : MonoBehaviour
{
    public Image img;
    public Transform trans; 

    void Awake()
    {
        img = GetComponent<Image>();
        trans = transform; 
    }

}
