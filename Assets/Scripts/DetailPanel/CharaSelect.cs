using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class CharaSelect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image characterPanel;
    public Sprite character;
    private GameObject gameManager;
    public Text costValue;
    public Text atValue;
    public Text speedValue;
    public Text roundValue;
    public string charaName;


    void Start(){
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(!gameManager.GetComponent<PushDefine>().Selected()){
            characterPanel.sprite = character;
            var c = characterPanel.color;
            characterPanel.color = new Color(1, 1, 1, 1);
            costValue.text=(-gameManager.GetComponent<StatusList>().GetCost(charaName)).ToString();
            atValue.text=gameManager.GetComponent<StatusList>().GetAt(charaName).ToString();
            speedValue.text=gameManager.GetComponent<StatusList>().GetInterval(charaName).ToString();
            roundValue.text=gameManager.GetComponent<StatusList>().GetRound(charaName).ToString();
        }
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        if(!gameManager.GetComponent<PushDefine>().Selected()){
            characterPanel.sprite = character;
            var c = characterPanel.color;
            characterPanel.color = new Color(1, 1, 1, 0);
        }
    }

    





}
