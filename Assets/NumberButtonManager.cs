using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class NumberButtonManager : MonoBehaviour
{
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
    [SerializeField] Text  fourDigitsText;
    [SerializeField] Text playerAnswer;
   
    
    string number;
    private string answer;
    private int a;
    private int b;
    private int times;

    public string Answer { get => answer; set => answer = value; }
    public int A { get => a; set => a = value; }
    public int B { get => b; set => b = value; }
    public int Times { get => times; set => times = value; }

    string fourDigitRandom;

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

        Text test = playerAnswer.GetComponent<Text>();
        test.text = number;
        Random crandom = new Random();
        fourDigitRandom = "";
        string[] array1 = new string[6];

        for(int i = 3; i != 6; i++)
        {
            
                do
                {
                    array1[i] = Convert.ToString(crandom.Next(0, 10));
                    print(array1[i]);
                } while (array1[i] != array1[i - 1] & array1[i] != array1[i - 2] & array1[i] != array1[i - 3]);
            

        }
        fourDigitRandom = (array1[3] + array1[4] + array1[5] + array1[6]);
        print(fourDigitRandom);

    }

    

    private void Enter()//string guess
    {

        Text test = playerAnswer.GetComponent<Text>();
        test.text = number;




        //a = 0;
        //b = 0;
        //foreach (char i in guess)
        //{
        //    if (answer.Contains(i))
        //    {
        //        if (answer.IndexOf(i) == guess.IndexOf(i))
        //        {
        //            a += 1;
        //        }
        //        else
        //        {
        //            b += 1;
        //        }
        //    }
        //}

        //             bool FindNumber(string nimber)
        //            {
        //                int count = 0;
        //                foreach (char i in number)
        //                {
        //                    foreach (char j in number)
        //                    {
        //                        if (i == j)
        //                        {
        //                            count += 1;
        //                        }
        //                    }
        //                    if (count > 1)
        //                    {
        //                        return true;
        //                    }
        //                    count = 0;
        //                }
        //                return false;
        //            }






    }


    //-----------------------------------------------------------------------------------------------
    private void Remove()
    {

        number = number.Remove(number.Length -1 , 1);
        fourDigitsText.text = number;
        print(number);
    }

    private void n0()
    {
        number = number + "0";
        print(number);
        fourDigitsText.text = number;
    }
    private void n1()
    {
        number = number + "1";
        print(number);
        fourDigitsText.text = number;
    }
    private void n2()
    {
        number = number + "2";
        print(number);
        fourDigitsText.text = number;
    }
    private void n3()
    {
        number = number + "3";
        print(number);
        fourDigitsText.text = number;
    }
    private void n4()
    {
        number = number + "4";
        print(number);
        fourDigitsText.text = number;
    }
    private void n5()
    {
        number = number + "5";
        print(number);
        fourDigitsText.text = number;
    }
    private void n6()
    {
        number = number + "6";
        print(number);
        fourDigitsText.text = number;
    }
    private void n7()
    {
        number = number + "7";
        print(number);
        fourDigitsText.text = number;
    }
    private void n8()
    {
        number = number + "8";
        print(number);
        fourDigitsText.text = number;
    }
    private void n9()
    {
        number = number + "9";
        print(number);
        fourDigitsText.text = number;
    }


    void Update()
    {
        //public Guess(int digit = 4)
        //        {
        //            string number = "1234567890";

        //            while (true)
        //            {
        //                answer = Shuffle(number).Substring(0, digit);
        //                if (answer[0] != '0')
        //                {
        //                    break;
        //                }
        //                a = 0;
        //                b = 0;
        //                times = 0;

        //            }



        //            string Shuffle(string s)
        //            {
        //                char[] s_array = s.ToCharArray();
        //                Random r = new Random();
        //                int n = s.Length;
        //                while (n > 1)
        //                {
        //                    n--;
        //                    int k = r.Next(n + 1);
        //                    var v = s_array[k];
        //                    s_array[k] = s_array[n];
        //                    s_array[n] = v;
        //                }
        //                return new string(s_array);
        //            }

    }
}
