using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToAndroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AndroidJavaClass ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity"); 
    }

    // Update is called once per frame
    public void PassToAndroid()
    {
        AndroidJavaClass ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity");
    }
}
