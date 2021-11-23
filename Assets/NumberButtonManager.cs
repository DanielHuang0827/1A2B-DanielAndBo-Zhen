using System;
using System.Collections;
using System.Collections.Generic;
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

    string number;



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
        
}

    private void Enter()
    {
       
   

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
        

    }
}
