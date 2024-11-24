using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SearchBar : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;

    public TMP_InputField searchBar;

    void Start()
    {
        searchBar.onValueChanged.AddListener(OnSearchTextChanged);
    }

    void OnSearchTextChanged(string searchText)
    {
        button1.gameObject.SetActive(button1.name.ToLower().Contains(searchText.ToLower()));
        button2.gameObject.SetActive(button2.name.ToLower().Contains(searchText.ToLower()));
        button3.gameObject.SetActive(button3.name.ToLower().Contains(searchText.ToLower()));
        button4.gameObject.SetActive(button4.name.ToLower().Contains(searchText.ToLower()));
        button5.gameObject.SetActive(button5.name.ToLower().Contains(searchText.ToLower()));
        button6.gameObject.SetActive(button5.name.ToLower().Contains(searchText.ToLower()));        button5.gameObject.SetActive(button5.name.ToLower().Contains(searchText.ToLower()));
        button7.gameObject.SetActive(button5.name.ToLower().Contains(searchText.ToLower()));
        button8.gameObject.SetActive(button5.name.ToLower().Contains(searchText.ToLower()));


    }

}