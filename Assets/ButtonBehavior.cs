using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonBehavior : MonoBehaviour
{

    [SerializeField] Button BackToMenu2;
    [SerializeField] Button SafeMode;
    [SerializeField] Button TimeLimitMode;
    [SerializeField] Button AllLimitMode;
    [SerializeField] Button HardMode;
    [SerializeField] Button Help;
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject Gaming;
    [SerializeField] GameObject HelpPanel;
    [SerializeField] Text FourDigits;
    [SerializeField] GameObject ModelButtons;
    

    void Start()
    {
        SafeMode.onClick.AddListener(SwitchMenu);
        TimeLimitMode.onClick.AddListener(SwitchMenu);
        AllLimitMode.onClick.AddListener(SwitchMenu);
        HardMode.onClick.AddListener(SwitchMenu);
        Help.onClick.AddListener(GoToHelpPanel);
        BackToMenu2.onClick.AddListener(SwitchToMenu);
        MainMenu.active = true;
        Gaming.active = false;
        HelpPanel.active = false;


    }

    private void SwitchToMenu()
    {
        MainMenu.active = true;
        HelpPanel.active = false;
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
            MainMenu.active = true;
            Gaming.active = false;
        }
        else if (MainMenu.active == true)
        {
            MainMenu.active = false;
            Gaming.active = true;
        }
        
    }

}
