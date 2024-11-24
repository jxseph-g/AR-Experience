using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchulungScript : MonoBehaviour
{
    public void OpenEniwaARApp()
    {
        string deepLink = "eniwar://open"; // replace with actual deep linkk
        Application.OpenURL(deepLink);
    }
}
