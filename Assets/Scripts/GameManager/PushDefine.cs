using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushDefine : MonoBehaviour
{

    public int selectCharaNum;
    private int selectCost;
    public bool isSetCaracter=false;
    private GameObject gameManager;
    public Image wizardPanel;
    public Image knightPanel;
    public Image kunoitiPanel;
    public Image charaPanel;
    public Sprite wizard;
    public Sprite knight;
    public Sprite kunoiti;
    public Text costValue;
    public Text atValue;
    public Text speedValue;
    public Text roundValue;



    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    public void IsSetTrue(){
        isSetCaracter = true;
    }

    public void IsSetFalse(){
        isSetCaracter = false;
    }

    public bool Selected(){
        return isSetCaracter;
    }

    public void SetCaraReset(){
        selectCharaNum=0;
    }


    public void PushWizard(){
        selectCost=gameManager.GetComponent<StatusList>().GetCost("wizard");
        if(this.GetComponent<MoneyKeeper>().GetCurrentMoney()-selectCost>=0){
            IsSetTrue();
            selectCharaNum=1;
            SelectPanelMark();
            charaPanel.sprite = wizard;
            var c = charaPanel.color;
            charaPanel.color = new Color(1, 1, 1, 1);
            costValue.text=(-gameManager.GetComponent<StatusList>().GetCost("wizard")).ToString();
            atValue.text=gameManager.GetComponent<StatusList>().GetAt("wizard").ToString();
            speedValue.text=gameManager.GetComponent<StatusList>().GetInterval("wizard").ToString();
            roundValue.text=gameManager.GetComponent<StatusList>().GetRound("wizard").ToString();
        }
        else{
            Debug.Log("not enough");
        }
        
        
    }

    public void PushKnight(){
        selectCost=gameManager.GetComponent<StatusList>().GetCost("knight");
        if(this.GetComponent<MoneyKeeper>().GetCurrentMoney()-selectCost>=0){
            IsSetTrue();
            selectCharaNum=2;
            SelectPanelMark();
            charaPanel.sprite = knight;
            var c = charaPanel.color;
            charaPanel.color = new Color(1, 1, 1, 1);
            costValue.text=(-gameManager.GetComponent<StatusList>().GetCost("knight")).ToString();
            atValue.text=gameManager.GetComponent<StatusList>().GetAt("knight").ToString();
            speedValue.text=gameManager.GetComponent<StatusList>().GetInterval("knight").ToString();
            roundValue.text=gameManager.GetComponent<StatusList>().GetRound("knight").ToString();
        }
        else{
            Debug.Log("not enough");
        }
        
    }

    public void PushKunoiti(){
        selectCost=gameManager.GetComponent<StatusList>().GetCost("kunoiti");
        if(this.GetComponent<MoneyKeeper>().GetCurrentMoney()-selectCost>=0){
            IsSetTrue();
            selectCharaNum=3;
            SelectPanelMark();
            charaPanel.sprite = kunoiti;
            var c = charaPanel.color;
            charaPanel.color = new Color(1, 1, 1, 1);
            costValue.text=(-gameManager.GetComponent<StatusList>().GetCost("kunoiti")).ToString();
            atValue.text=gameManager.GetComponent<StatusList>().GetAt("kunoiti").ToString();
            speedValue.text=gameManager.GetComponent<StatusList>().GetInterval("kunoiti").ToString();
            roundValue.text=gameManager.GetComponent<StatusList>().GetRound("kunoiti").ToString();
        }
        else{
            Debug.Log("not enough");
        }
        
    }

    public void SelectPanelMark(){
        wizardPanel.color=new Color(1, 1, 1, 0.3f);
        knightPanel.color=new Color(1, 1, 1, 0.3f);
        kunoitiPanel.color=new Color(1, 1, 1, 0.3f);
        if(selectCharaNum==1){
            wizardPanel.color=new Color(0, 1, 0, 0.3f);
        }
        if(selectCharaNum==2){
            knightPanel.color=new Color(0, 1, 0, 0.3f);
        }
        if(selectCharaNum==3){
            kunoitiPanel.color=new Color(0, 1, 0, 0.3f);
        }
    } 
}
