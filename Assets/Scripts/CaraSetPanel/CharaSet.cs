using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaSet : MonoBehaviour
{
    private Image characterPanel;
    private GameObject gameManager;
    public Sprite wizard;
    public Sprite knight;
    public Sprite kunoiti;
    public Sprite boxImage;
    public int charaNum=0;
    public GameObject charaDetailPanel;
    public GameObject charaSelectPanel;
    // Start is called before the first frame update
    void Start()
    {
        characterPanel=this.GetComponent<Image>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CharaSeting(){
        if(!this.GetComponent<PanelStatus>().GetIsSelected()){
            if(gameManager.GetComponent<PushDefine>().isSetCaracter){
                if(gameManager.GetComponent<PushDefine>().selectCharaNum==1){
                    characterPanel.sprite = wizard;
                    var c = characterPanel.color;
                    characterPanel.color = new Color(1, 1, 1, 1);
                    gameManager.GetComponent<PushDefine>().IsSetFalse();
                    gameManager.GetComponent<PushDefine>().SetCaraReset();
                    charaNum=1;
                    gameManager.GetComponent<PushDefine>().SelectPanelMark();
                    gameManager.GetComponent<MoneyKeeper>().MoneyCalc(-(gameManager.GetComponent<StatusList>().GetCost("wizard")));
                    gameManager.GetComponent<MoneyKeeper>().MoneyValueUpdate();
                    this.GetComponent<PanelStatus>().IsSetTrue();
                    this.GetComponent<PanelStatus>().ChangeName("wizard");
                    this.GetComponent<PanelStatus>().ChangeCost(gameManager.GetComponent<StatusList>().GetCost("wizard"));
                    this.GetComponent<PanelStatus>().ChangeAt(gameManager.GetComponent<StatusList>().GetAt("wizard"));
                    this.GetComponent<PanelStatus>().ChangeInterval(gameManager.GetComponent<StatusList>().GetInterval("wizard"));
                    this.GetComponent<PanelStatus>().ChangeRound(gameManager.GetComponent<StatusList>().GetRound("wizard"));


                }
                else if(gameManager.GetComponent<PushDefine>().selectCharaNum==2){
                    characterPanel.sprite = knight;
                    var c = characterPanel.color;
                    characterPanel.color = new Color(1, 1, 1, 1);
                    gameManager.GetComponent<PushDefine>().IsSetFalse();
                    gameManager.GetComponent<PushDefine>().SetCaraReset();
                    charaNum=2;
                    gameManager.GetComponent<PushDefine>().SelectPanelMark();
                    gameManager.GetComponent<MoneyKeeper>().MoneyCalc(-gameManager.GetComponent<StatusList>().GetCost("knight"));
                    gameManager.GetComponent<MoneyKeeper>().MoneyValueUpdate();
                    this.GetComponent<PanelStatus>().IsSetTrue();
                    this.GetComponent<PanelStatus>().ChangeName("knight");
                    this.GetComponent<PanelStatus>().ChangeCost(gameManager.GetComponent<StatusList>().GetCost("knight"));
                    this.GetComponent<PanelStatus>().ChangeAt(gameManager.GetComponent<StatusList>().GetAt("knight"));
                    this.GetComponent<PanelStatus>().ChangeInterval(gameManager.GetComponent<StatusList>().GetInterval("knight"));
                    this.GetComponent<PanelStatus>().ChangeRound(gameManager.GetComponent<StatusList>().GetRound("knight"));

                }
                else if(gameManager.GetComponent<PushDefine>().selectCharaNum==3){
                    characterPanel.sprite = kunoiti;
                    var c = characterPanel.color;
                    characterPanel.color = new Color(1, 1, 1, 1);
                    gameManager.GetComponent<PushDefine>().IsSetFalse();
                    gameManager.GetComponent<PushDefine>().SetCaraReset();
                    charaNum=3;
                    gameManager.GetComponent<PushDefine>().SelectPanelMark();
                    gameManager.GetComponent<MoneyKeeper>().MoneyCalc(-gameManager.GetComponent<StatusList>().GetCost("kunoiti"));
                    gameManager.GetComponent<MoneyKeeper>().MoneyValueUpdate();
                    this.GetComponent<PanelStatus>().IsSetTrue();
                    this.GetComponent<PanelStatus>().ChangeName("kunoiti");
                    this.GetComponent<PanelStatus>().ChangeCost(gameManager.GetComponent<StatusList>().GetCost("kunoiti"));
                    this.GetComponent<PanelStatus>().ChangeAt(gameManager.GetComponent<StatusList>().GetAt("kunoiti"));
                    this.GetComponent<PanelStatus>().ChangeInterval(gameManager.GetComponent<StatusList>().GetInterval("kunoiti"));
                    this.GetComponent<PanelStatus>().ChangeRound(gameManager.GetComponent<StatusList>().GetRound("kunoiti"));

                }
            }
        }
        else{
            gameManager.GetComponent<ActiveSet>().MonsterDetailPanelFalse();
            gameManager.GetComponent<ActiveSet>().CharaSelectPanelFalse();
            gameManager.GetComponent<ActiveSet>().CharaDetailPanelTrue();
            gameManager.GetComponent<DetailPanelSet>().SetCharaImage(this.GetComponent<PanelStatus>().GetName());
            gameManager.GetComponent<DetailPanelSet>().SetObject(this.gameObject);
            // Debug.Log("osareta");
        }

        
    }
    public void OutSetting(){
        this.GetComponent<PanelStatus>().IsSetFalse();
        this.GetComponent<PanelStatus>().ChangeName("");
        this.GetComponent<PanelStatus>().ChangeCost(0);
        this.GetComponent<PanelStatus>().ChangeAt(0);
        this.GetComponent<PanelStatus>().ChangeInterval(0);
        this.GetComponent<PanelStatus>().ChangeRound(0);
        this.GetComponent<PanelStatus>().ChangeATCost(40);
        this.GetComponent<PanelStatus>().ChangeIntervalCost(40);
        this.GetComponent<PanelStatus>().ChangeRoundCost(40);

        charaNum=0;
        characterPanel.sprite = boxImage;
        var c = characterPanel.color;
        characterPanel.color = new Color(1, 1, 1, 0.13f);
    }
}
