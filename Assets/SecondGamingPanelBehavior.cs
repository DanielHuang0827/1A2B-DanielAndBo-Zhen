using System;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;


public class SecondGamingPanelBehavior : MonoBehaviour
{
    #region [SF]各種大按鈕
    [SerializeField] Button restart;
    [SerializeField] Button hints;
    [SerializeField] Button backToMenu;

    [SerializeField] GameObject askForSure;
    [SerializeField] Button yes;
    [SerializeField] Button no;

    [SerializeField] Button congratulationBackToMenu;
    #endregion

    [SerializeField] GameObject panelMenu;
    [SerializeField] GameObject Congratulation;

    #region [SF]Number And Enter Button
    [SerializeField] Button number0;
    [SerializeField] Button number1;
    [SerializeField] Button number2;
    [SerializeField] Button number3;
    [SerializeField] Button number4;
    [SerializeField] Button number5;
    [SerializeField] Button number6;
    [SerializeField] Button number7;
    [SerializeField] Button number8;
    [SerializeField] Button number9;
    [SerializeField] Button remove;
    [SerializeField] Button enter;
    #endregion

    [SerializeField] Text fourDigitsText;
    [SerializeField] Text playerAnswer;
    [SerializeField] Text counter;
    [SerializeField] Text congratulationInfomation;
    [SerializeField] Text timerText;


    #region 變數預設
    string number;
    string answer;
    string printAnswer;
    bool BackOrNot;
    bool timerTurnOn;
    int count;
    private int[] ans = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//正確答案
    private String[] gnum = new string[10];//猜的答案數字
    private int tmp, r;
    private Random ran = new Random();
    DateTime startTime;
    float timer_f = 0f;
    int timer_i = 0;
    int minute = 0;
    int second = 0;

    #endregion

    void Start()
    {
        number1.onClick.AddListener(n1);
        number2.onClick.AddListener(n2);
        number3.onClick.AddListener(n3);
        number4.onClick.AddListener(n4);
        number5.onClick.AddListener(n5);
        number6.onClick.AddListener(n6);
        number7.onClick.AddListener(n7);
        number8.onClick.AddListener(n8);
        number9.onClick.AddListener(n9);
        number0.onClick.AddListener(n0);
        remove.onClick.AddListener(Remove);
        enter.onClick.AddListener(Enter);
        backToMenu.onClick.AddListener(BackToMenu);
        restart.onClick.AddListener(Restart);
        hints.onClick.AddListener(Hints);
        yes.onClick.AddListener(Yes);
        no.onClick.AddListener(No);
        congratulationBackToMenu.onClick.AddListener(Yes);

        ResetMethod();






    }

    public void ResetMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            ans[i] = i;
        }
        for (int i = 0; i < 10; i++)
        {
            r = ran.Next(0, 10);
            print("r" + r);
            tmp = ans[r];
            print("tmp" + tmp);
            ans[r] = ans[9 - i];
            print("ans[r]" + ans[r]);
            ans[9 - i] = tmp;
            print("ans[9-i]" + ans[9 - i]);
            print("------------------------------------");
        }
        printAnswer = "";
        count = 0;
        counter.text = count.ToString();
        playerAnswer.text = "";
        askForSure.active = false;
        Congratulation.active = false;
        BackOrNot = false;
        timerTurnOn = false;
        timer_f = 0f;
        timer_i = 0;
        number = "";
        fourDigitsText.text = number;

    }

    #region Number
    private void n0()
    {
        timerTurnOn = true;
        number = number + "0";
        print(number);
        fourDigitsText.text = number;
    }
    private void n1()
    {
        timerTurnOn = true;
        number = number + "1";
        print(number);
        fourDigitsText.text = number;
    }
    private void n2()
    {
        timerTurnOn = true;
        number = number + "2";
        print(number);
        fourDigitsText.text = number;
    }
    private void n3()
    {
        timerTurnOn = true;
        number = number + "3";
        print(number);
        fourDigitsText.text = number;
    }
    private void n4()
    {
        timerTurnOn = true;
        number = number + "4";
        print(number);
        fourDigitsText.text = number;
    }
    private void n5()
    {
        timerTurnOn = true;
        number = number + "5";
        print(number);
        fourDigitsText.text = number;
    }
    private void n6()
    {
        timerTurnOn = true;
        number = number + "6";
        print(number);
        fourDigitsText.text = number;
    }
    private void n7()
    {
        timerTurnOn = true;
        number = number + "7";
        print(number);
        fourDigitsText.text = number;
    }
    private void n8()
    {
        timerTurnOn = true;
        number = number + "8";
        print(number);
        fourDigitsText.text = number;
    }
    private void n9()
    {
        timerTurnOn = true;
        number = number + "9";
        print(number);
        fourDigitsText.text = number;
    }


    #endregion

    #region Main action
    private void Enter()
    {
        number = fourDigitsText.text;
        string num = "";
        int a = 0, b = 0;
        count++;
        if (number.Length != 4)
        {
            print("請輸入4個不一樣的數字");
        }
        else
        {
            for (int j = 1; j <= 4; j++)
            {
                gnum[j] = number.Substring(j - 1, 1);
                num += gnum[j];
            }
            if ((gnum[1] == gnum[2] || gnum[1] == gnum[3] ||
                gnum[1] == gnum[4] || gnum[2] == gnum[3] ||
                gnum[2] == gnum[4] || gnum[3] == gnum[4]))
            {
                print("不能輸入重複的數字哦");
            }
            else
            {
                for (int k = 1; k <= 4; k++)
                {
                    for (int l = 1; l <= 4; l++)
                    {
                        if (gnum[k] == ans[l].ToString())
                        {
                            if (k == l)
                            {
                                a++;
                            }
                            else if (k != l)
                            {
                                b++;
                            }
                        }
                    }
                }
                answer = (num + "-----" + a.ToString() + "A" + b.ToString() + "B" + "\r\n");

                playerAnswer.text = printAnswer + answer;

                printAnswer = printAnswer + answer;

                counter.text = count.ToString();
                print(count);

            }
            if (a == 4 && b == 0)
            {
                Congratulation.active = true;
                string label2 = "";
                for (int i = 1; i <= 4; i++) label2 += ans[i];

                congratulationInfomation.text = ("答案就是" + label2 + "\r\n" + "一共經過" + count + "回合" + "\r\n" + "總共花費：" + minute + "分" + second + "秒" + "\r\n" + "您贏過很多位玩家呢");
                BackOrNot = true;
                print("恭喜你猜對了");
                //退出遊戲
            }
            else if (count == 11)
            {
                print("你要再加油了");
                //退出遊戲
            }
            number = "";
            fourDigitsText.text = number;

        }





    }
    private void Remove()
    {

        number = number.Remove(number.Length - 1, 1);
        fourDigitsText.text = number;
        print(number);
    }
    #endregion

    #region SeeAnswer

    //private void button2_SeeAnswer(object sender, EventArgs e)
    //{
    //    string label2 = "";
    //    for (int i = 1; i <= 4; i++)
    //    {
    //        label2 += ans[i];
    //    }
    //    print(label2);
    //}
    #endregion

    #region Playagain
    //private void button3_PlayAgain(object sender, EventArgs e)
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        r = ran.Next(0, 10 - i);
    //        tmp = ans[r];
    //        ans[r] = ans[9 - i];
    //        ans[9 - i] = tmp;
    //    }
    //    for (int j = 1; j <= 4; j++)
    //    {
    //        gnum[j] = "";
    //    }
    //}
    #endregion

    #region 大按鈕們的方法
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
        string label2 = "";
        for (int i = 1; i <= 4; i++)
        {
            label2 += ans[i];
        }
        print(label2);
    }
    private void Yes()
    {

        if (BackOrNot == true)//判斷他是不是點選回主畫面按鈕，若是，則跳回主畫面，若否，則重新出題
        {

            panelMenu.active = true;
            //還缺一個告訴玩家的告示牌圖檔
        }
        ResetMethod();



    }
    private void No()
    {
        askForSure.active = false;
    }
    #endregion

    void FixedUpdate()
    {


        if (timerTurnOn == true)
        {
            timer_f += Time.deltaTime;
            timer_i = (int)timer_f;
        }


        turn_time();
        //印出時間動作
        if (minute < 10)
        {

            if (second < 10)
            {
                timerText.text = "0" + minute + ":0" + second;
            }
            else
            {
                timerText.text = "0" + minute + ":" + second;
            }
        }
        else
        {
            if (second < 10)
            {
                timerText.text = minute + ":0" + second;
            }
            else
            {
                timerText.text = minute + ":" + second;
            }
        }
    }
    void turn_time()
    {
        minute = timer_i / 60;
        second = timer_i % 60;
    }


}
