using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.UI;

public class AnleitungSwitch: MonoBehaviour
{
    public Image image;
    public Button imageButtonSwitch; 
    // Start is called before the first frame update
    void Start()
    {
        image.gameObject.SetActive(false);
        imageButtonSwitch.onClick.AddListener(SwitchAnleitung);

    }

    public void SwitchAnleitung()
    {
        image.gameObject.SetActive(!image.gameObject.activeSelf);
    }
}
