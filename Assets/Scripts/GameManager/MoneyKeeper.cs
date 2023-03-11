using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyKeeper : MonoBehaviour
{
    public Text moneyValue;
    public int initMoney;
    private int currentMoney;

    // Start is called before the first frame update
    void Start()
    {
        currentMoney=initMoney;
        moneyValue.text=currentMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoneyCalc(int x){
        currentMoney+=x;
        moneyValue.text=currentMoney.ToString();
    }
    public void MoneyValueUpdate(){
        moneyValue.text=currentMoney.ToString();
    }
    public int GetCurrentMoney(){
        return currentMoney;
    }

}
