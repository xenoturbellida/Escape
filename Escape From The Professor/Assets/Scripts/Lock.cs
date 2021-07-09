using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button buttonAsterisk;
    public Button button0;
    public Button buttonHash;

    public Text codeText;
    private string _currentText = "";
    public string properKey = "2908";

    public Animator leftDoor;
    public Animator rightDoor;
    public bool wasSolved;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(ButtonClicked1);
        button2.onClick.AddListener(ButtonClicked2);
        button3.onClick.AddListener(ButtonClicked3);
        button4.onClick.AddListener(ButtonClicked4);
        button5.onClick.AddListener(ButtonClicked5);
        button6.onClick.AddListener(ButtonClicked6);
        button7.onClick.AddListener(ButtonClicked7);
        button8.onClick.AddListener(ButtonClicked8);
        button9.onClick.AddListener(ButtonClicked9);
        buttonAsterisk.onClick.AddListener(ButtonClickedAsterisk);
        button0.onClick.AddListener(ButtonClicked0);
        buttonHash.onClick.AddListener(ButtonClickedHash);
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = _currentText;

        if (_currentText == properKey)
        {
            wasSolved = true;
            OpenDoor();
        }

        if (_currentText.Length >= 4)
        {
            _currentText = "";
        }
    }

    void OpenDoor()
    {
        leftDoor.SetBool("isOpen", true);
        rightDoor.SetBool("isOpen", true);
    }

    public void AddDigit(string digit)
    {
        _currentText += digit;
    }

    private void ButtonClicked1()
    {
        Debug.Log(button1.name);
        AddDigit("1");
    }
    
    private void ButtonClicked2()
    {
        Debug.Log(button2.name);
        AddDigit("2");
    }
    
    private void ButtonClicked3()
    {
        Debug.Log(button3.name);
        AddDigit("3");
    }
    
    private void ButtonClicked4()
    {
        Debug.Log(button4.name);
        AddDigit("4");
    }
    
    private void ButtonClicked5()
    {
        Debug.Log(button5.name);
        AddDigit("5");
    }
    
    private void ButtonClicked6()
    {
        Debug.Log(button6.name);
        AddDigit("6");
    }
    
    private void ButtonClicked7()
    {
        Debug.Log(button7.name);
        AddDigit("7");
    }
    
    private void ButtonClicked8()
    {
        Debug.Log(button8.name);
        AddDigit("8");
    }
    
    private void ButtonClicked9()
    {
        Debug.Log(button9.name);
        AddDigit("9");
    }
    
    private void ButtonClickedAsterisk()
    {
        Debug.Log(buttonAsterisk.name);
        AddDigit("*");
    }
    
    private void ButtonClicked0()
    {
        Debug.Log(button0.name);
        AddDigit("0");
    }
    
    private void ButtonClickedHash()
    {
        Debug.Log(buttonHash.name);
        AddDigit("#");
    }
}
