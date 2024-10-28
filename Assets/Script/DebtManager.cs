using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebtManager : MonoBehaviour
{
    public Button plusButton;
    public GameObject inputPanel1;
    public GameObject inputPanel2;
    public GameObject inputPanel3;


    void Start()
    {
        plusButton.onClick.AddListener(OpenInputPanel1);
        inputPanel1.SetActive(false);
        plusButton.onClick.AddListener(OpenInputPanel2);
        inputPanel2.SetActive(false);
        plusButton.onClick.AddListener(OpenInputPanel3);
        inputPanel3.SetActive(false);
    }

    void OpenInputPanel1()
    {
        inputPanel1.SetActive(true);// Show input panel
    }
    void OpenInputPanel2()
    {
        inputPanel2.SetActive(true);// Show input panel
    }
    void OpenInputPanel3()
    {
        inputPanel3.SetActive(true);// Show input panel
    }


}