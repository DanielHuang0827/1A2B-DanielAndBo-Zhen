using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamingPanelBehavior : MonoBehaviour
{
    [SerializeField] Button backToMenu;
    [SerializeField] Button restart;
    [SerializeField] Button hints;
    [SerializeField] GameObject askForSure;
    [SerializeField] Button yes;
    [SerializeField] Button no;
    [SerializeField] GameObject panelMenu;


    bool BackOrNot;


    // Start is called before the first frame update
    void Start()
    {
        backToMenu.onClick.AddListener(BackToMenu);
        restart.onClick.AddListener(Restart);
        hints.onClick.AddListener(Hints);
        yes.onClick.AddListener(Yes);
        no.onClick.AddListener(No);
        askForSure.active = false;
        BackOrNot = false;

    }

    private void BackToMenu()
    {
        BackOrNot = true;
        askForSure.active = true;
    }

    private void Restart()
    {
        BackOrNot = false;
        askForSure.active = true;
    }

    private void Hints()
    {
        //這邊要做提示鈕，告訴玩家其中一個字
    }

    private void Yes()
    {
        if (BackOrNot == true)//判斷他是不是點選回主畫面按鈕，若是，則跳回主畫面，若否，則重新出題
        {
            askForSure.active = false;
            panelMenu.active = true;
            //還缺一個告訴玩家的告示牌圖檔
        }
        else
        {
            askForSure.active = false;
            //還缺一個告訴玩家的告示牌圖檔
            //這邊要打重新開始的程式
        }

    }

    private void No()
    {
        askForSure.active = false;
    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
