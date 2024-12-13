using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextVerschwinden : MonoBehaviour
{
        public Image image;
        // Start is called before the first frame update
        void Start()
        {
            image.gameObject.SetActive(true);
        }

    public void OnImageClick()
    {
        // Deactivate the blurred image when clicked
        image.gameObject.SetActive(false);
    }

}
