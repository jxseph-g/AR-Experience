using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextColorGroupSwitcher : MonoBehaviour
{
    public GameObject blackTextGroup;
    public GameObject purpleTextGroup;
    public GameObject whiteTextGroup;

    public void ShowBlackText()
    {
        blackTextGroup.SetActive(true);
        purpleTextGroup.SetActive(false);
        whiteTextGroup.SetActive(false);
    }

    public void ShowPurpleText()
    {
        blackTextGroup.SetActive(false);
        purpleTextGroup.SetActive(true);
        whiteTextGroup.SetActive(false);
    }

    public void ShowWhiteText()
    {
        blackTextGroup.SetActive(false);
        purpleTextGroup.SetActive(false);
        whiteTextGroup.SetActive(true);
    }
}
