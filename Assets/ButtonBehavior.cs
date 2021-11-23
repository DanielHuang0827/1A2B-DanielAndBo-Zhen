using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonBehavior : MonoBehaviour
{
    [SerializeField] Button BackToMenu;
    [SerializeField] Button BackToMenu2;
    [SerializeField] Button Restart;
    [SerializeField] Button Hints;
    [SerializeField] Button SafeMode;
    [SerializeField] Button TimeLimitMode;
    [SerializeField] Button AllLimitMode;
    [SerializeField] Button HardMode;
    [SerializeField] Button Help;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject Gaming;
    [SerializeField] GameObject HelpPanel;
    [SerializeField] Text FourDigits;
    

    void Start()
    {


        BackToMenu.onClick.AddListener(SwitchMenu);
        SafeMode.onClick.AddListener(SwitchMenu);
        TimeLimitMode.onClick.AddListener(SwitchMenu);
        AllLimitMode.onClick.AddListener(SwitchMenu);
        HardMode.onClick.AddListener(SwitchMenu);
        Help.onClick.AddListener(GoToHelpPanel);
        Restart.onClick.AddListener(RestartTheGame);
        BackToMenu2.onClick.AddListener(SwitchToMenu);
        //MainMenu.active = true;
        //Gaming.active = false;
        //HelpPanel.active = false;


    }

    private void SwitchToMenu()
    {
        MainMenu.active = true;
        HelpPanel.active = false;
    }

    public void RestartTheGame()
    {
        FourDigits.text = "";
        


    }

    private void GoToHelpPanel()
    {

        MainMenu.active = false;
        HelpPanel.active = true;

    }


    void SwitchMenu()
    { 

        if (MainMenu.active == false)
        {
            print(MainMenu.active);
            Debug.Log("A open Menu");
            MainMenu.active = true;
            Gaming.active = false;
            Debug.Log("open Menu");
            
        }
        else if (MainMenu.active == true)
        {
            print(MainMenu.active);
            Debug.Log("A Start Game");
            MainMenu.active = false;
            Gaming.active = true;
            Debug.Log("Start Game");
            
        }
        
    }

}
