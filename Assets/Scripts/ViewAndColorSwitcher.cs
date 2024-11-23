using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewAndColorSwitcher : MonoBehaviour
{
    public GameObject threeDBlackText;
    public GameObject threeDPurpleText;
    public GameObject twoDBlackText;
    public GameObject twoDPurpleText;

    private bool is3D = true;

    void Start()
    {
        // Initially activate 3D model and its purple text
        threeDBlackText.SetActive(false);
        threeDPurpleText.SetActive(true);
        twoDBlackText.SetActive(false);
        twoDPurpleText.SetActive(false);
    }

    public void SwitchView()
    {
        is3D = !is3D;
        // Immediately update the text visibility after switching the view
        if (is3D)
        {
            threeDBlackText.SetActive(false);
            threeDPurpleText.SetActive(true); // Show purple by default for 3D
            twoDBlackText.SetActive(false);
            twoDPurpleText.SetActive(false);
        }
        else
        {
            threeDBlackText.SetActive(false);
            threeDPurpleText.SetActive(false);
            twoDBlackText.SetActive(false);
            twoDPurpleText.SetActive(true); // Show purple by default for 2D
        }
    }

    public void ShowBlackText()
    {
        if (is3D)
        {
            threeDBlackText.SetActive(true);
            twoDBlackText.SetActive(false);
            threeDPurpleText.SetActive(false);
            twoDPurpleText.SetActive(false);
        }
        if (!is3D)
        {
            twoDBlackText.SetActive(true);
            threeDBlackText.SetActive(false);
            threeDPurpleText.SetActive(false);
            twoDPurpleText.SetActive(false);
        }

    }

    public void ShowPurpleText()
    {
        if (is3D)
        {
            threeDPurpleText.SetActive(true);
            twoDPurpleText.SetActive(false);
            threeDBlackText.SetActive(false);
            twoDBlackText.SetActive(false);
        }
        if (!is3D)
        {
            threeDPurpleText.SetActive(false);
            twoDPurpleText.SetActive(true);
            threeDBlackText.SetActive(false);
            twoDBlackText.SetActive(false);
        }
    }
}

