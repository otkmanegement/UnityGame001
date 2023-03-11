using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelStatus : MonoBehaviour
{
    public string charaName;
    public int cost;
    public float at;
    public float interval;
    public float round;
    public bool isSelected=false;
    public float atCost=40;
    public float intervalCost=40;
    public float roundCost=40;
    private float sellMoney;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {}

    public void IsSetFalse(){
        isSelected=false;
    }

    public void IsSetTrue(){
        isSelected=true;
    }
    public bool GetIsSelected(){
        return isSelected;
    }

    public float GetAt(){
        return at;
    }
    public float GetInterval(){
        return interval;
    }
    public float GetRound(){
        return round;
    }
    public float GetAtCost(){
        return atCost;
    }
    public float GetIntervalCost(){
        return intervalCost;
    }
    public float GetRoundCost(){
        return roundCost;
    }

    public string GetName(){
        return charaName;
    }

    public float GetSellMoney(){
        sellMoney=(float)cost/2.0f;
        return sellMoney;
    }

    public void ChangeName(string x){
        charaName=x;
    }

    public void ChangeCost(int x){
        cost=x;
    }

    public void ChangeAt(float x){
        at=x;
    }
    public void ChangeInterval(float x){
        interval=x;
    }
    public void ChangeRound(float x){
        round=x;
    }

    public void ChangeATCost(float x){
        atCost=x;
    }
    public void ChangeIntervalCost(float x){
        intervalCost=x;
    }
    public void ChangeRoundCost(float x){
        roundCost=x;
    }


    public void AtUp(){
        cost+=(int)atCost;
        at*=1.5f;
        atCost*=1.5f;
    }
    public void IntervalUp(){
        cost+=(int)intervalCost;
        interval/=1.5f;
        intervalCost*=1.5f;
    }
    public void RoundUp(){
        cost+=(int)roundCost;
        round*=1.5f;
        roundCost*=1.5f;

    }


}
