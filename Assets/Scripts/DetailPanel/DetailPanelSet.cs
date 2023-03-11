using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailPanelSet : MonoBehaviour
{
    public Image charaPanel;
    public Sprite wizard;
    public Sprite knight;
    public Sprite kunoiti;
    private GameObject selectPanel;
    public Text atValue;
    public Text intervalValue;
    public Text roundValue;
    public Text atCost;
    public Text intervalCost;
    public Text roundCost;
    public Text sellMoney;
    private GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetCharaImage(string name){
        if(name=="wizard"){
            charaPanel.sprite = wizard;
            var c = charaPanel.color;
            charaPanel.color = new Color(1, 1, 1, 1);
        }
        else if(name=="knight"){
            charaPanel.sprite = knight;
            var c = charaPanel.color;
            charaPanel.color = new Color(1, 1, 1, 1);
        }
        else if(name=="kunoiti"){
            charaPanel.sprite = kunoiti;
            var c = charaPanel.color;
            charaPanel.color = new Color(1, 1, 1, 1);
        }
        
    }

    public void SetObject(GameObject obj){
        selectPanel=obj;
        TextUpdate();
    }

    public void AtUpButton(){
        if((float)gameManager.GetComponent<MoneyKeeper>().GetCurrentMoney()>=Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetAtCost())){
            gameManager.GetComponent<MoneyKeeper>().MoneyCalc(-(int)selectPanel.GetComponent<PanelStatus>().GetAtCost());
            selectPanel.GetComponent<PanelStatus>().AtUp();
            TextUpdate();
        }
        
    }
    public void IntervalUpButton(){
        if((float)gameManager.GetComponent<MoneyKeeper>().GetCurrentMoney()>=Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetIntervalCost())){
            gameManager.GetComponent<MoneyKeeper>().MoneyCalc(-(int)selectPanel.GetComponent<PanelStatus>().GetIntervalCost());
            selectPanel.GetComponent<PanelStatus>().IntervalUp();
            TextUpdate();
        }
    }
    public void RoundUpButton(){
        if((float)gameManager.GetComponent<MoneyKeeper>().GetCurrentMoney()>=Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetRoundCost())){
            gameManager.GetComponent<MoneyKeeper>().MoneyCalc(-(int)selectPanel.GetComponent<PanelStatus>().GetRoundCost());
            selectPanel.GetComponent<PanelStatus>().RoundUp();
            TextUpdate();
        }
    }
    public void SellButton(){
        gameManager.GetComponent<MoneyKeeper>().MoneyCalc((int)selectPanel.GetComponent<PanelStatus>().GetSellMoney());
        selectPanel.GetComponent<CharaSet>().OutSetting();
    }
    private void TextUpdate(){
        atValue.text=Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetAt()).ToString();
        intervalValue.text=Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetInterval()).ToString();
        roundValue.text=Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetRound()).ToString();
        atCost.text="-"+Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetAtCost()).ToString()+"G";
        intervalCost.text="-"+Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetIntervalCost()).ToString()+"G";
        roundCost.text="-"+Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetRoundCost()).ToString()+"G";
        sellMoney.text="+"+Mathf.Round(selectPanel.GetComponent<PanelStatus>().GetSellMoney()).ToString()+"G";
    }

}
