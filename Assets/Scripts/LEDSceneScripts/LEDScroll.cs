using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject led1;
    public GameObject led2; 
    public GameObject led3;
    public GameObject led4;
    public GameObject led5;
    public GameObject led6;
    public GameObject led7;

    public Image led1Image;
    public Image led2Image;
    public Image led3Image;
    public Image led4Image;
    public Image led5Image;
    public Image led6Image;
    public Image led7Image;

    public TMP_Text led1Text;
    public TMP_Text led2Text;
    public TMP_Text led3Text;
    public TMP_Text led4Text;
    public TMP_Text led5Text;
    public TMP_Text led6Text;
    public TMP_Text led7Text;
    void Start()
    {
        scrollbar.onValueChanged.AddListener(OnScrollbarValueChanged);
    }

    void OnScrollbarValueChanged(float value)
    {
        int currentStep = Mathf.RoundToInt(value * (scrollbar.numberOfSteps - 1));
        UpdateARObjects(currentStep);
    }

    void UpdateARObjects(int currentStep)
    {
        // Deactivate all LEDs and their corresponding UI elements
        led1.SetActive(false);
        led2.SetActive(false);
        led3.SetActive(false);
        led4.SetActive(false);
        led5.SetActive(false);
        led6.SetActive(false);
        led7.SetActive(false);

        led1Image.enabled = false;
        led2Image.enabled = false;
        led3Image.enabled = false;
        led4Image.enabled = false;
        led5Image.enabled = false;
        led6Image.enabled = false;
        led7Image.enabled = false;

        led1Text.enabled = false;
        led2Text.enabled = false;
        led3Text.enabled = false;
        led4Text.enabled = false;
        led5Text.enabled = false;
        led6Text.enabled = false;
        led7Text.enabled = false;

        // Activate the LEDs and their UI elements based on the current step
        switch (currentStep)
        {
            case 0:
                led1.SetActive(true);
                led1Image.enabled = true;
                led1Text.enabled = true;
                break;
            case 1:
                led2.SetActive(true);
                led2Image.enabled = true;
                led2Text.enabled = true;
                break;
            case 2:
                led3.SetActive(true);
                led3Image.enabled = true;
                led3Text.enabled = true;
                break;
            case 3:
                led4.SetActive(true);
                led4Image.enabled = true;
                led4Text.enabled = true;
                break;
            case 4:
                led5.SetActive(true);
                led5Image.enabled = true;
                led5Text.enabled = true;
                break;
            case 5:
                led6.SetActive(true);
                led6Image.enabled = true;
                led6Text.enabled = true;
                break;
            case 6:
                led7.SetActive(true);
                led7Image.enabled = true;
                led7Text.enabled = true;
                break;
        }
    }
}