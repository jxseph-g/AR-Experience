using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVisualButton : MonoBehaviour
{
    [SerializeField] 
    private GameObject threeDView;  

    [SerializeField] 
    private GameObject twoDView;    

    [SerializeField] 
    private UnityEngine.UI.Button switchButton; // Assign your button here


    private bool is3D = true; // Start with 3D view active

    void Start()
    {
        // Make sure only one view is active initially
        threeDView.SetActive(is3D);
        twoDView.SetActive(!is3D);

        // Add a listener to the button to call the SwitchView function
        switchButton.onClick.AddListener(SwitchView);
    }

    public void SwitchView()
    {
        is3D = !is3D; // Toggle between 3D and 2D

        threeDView.SetActive(is3D);
        twoDView.SetActive(!is3D);
    }
}