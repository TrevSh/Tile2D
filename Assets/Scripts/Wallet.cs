using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public static Wallet instance { get; private set; }

    public TMP_Text walletText;
    public int currentMoney;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        walletText.text = "$" + currentMoney.ToString(); //DONT FORGET .ToString()!!!!
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakeMoney(int moneyValue)
    {
        currentMoney += moneyValue;
        walletText.text ="$" + currentMoney.ToString();
        //Debug.Log("You've been money'd! You now have " + money.ToString() + " dollars!");
        
    }
}
