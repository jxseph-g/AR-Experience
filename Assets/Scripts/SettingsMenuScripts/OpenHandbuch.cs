using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// https://docs.unity3d.com/ScriptReference/Application.OpenURL.html

public class OpenHandbuch : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://support.huawei.com/enterprise/en/doc/EDOC1100136173");
    }
}
