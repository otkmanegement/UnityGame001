using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSet : MonoBehaviour
{
    public GameObject monsterDetailPanel;
    public GameObject charaDetailPanel;
    public GameObject charaSelectPanel;
    // Start is called before the first frame update
    void Start()
    {
        CharaDetailPanelFalse();
        CharaSelectPanelFalse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharaDetailPanelTrue(){
        if(!charaDetailPanel.activeSelf){
            charaDetailPanel.SetActive(true);
        }
        
    }
    public void CharaSelectPanelTrue(){
        if(!charaSelectPanel.activeSelf){
            charaSelectPanel.SetActive(true);
        }
        
    }
    public void MonsterDetailPanelTrue(){
        if(!monsterDetailPanel.activeSelf){
            monsterDetailPanel.SetActive(true);
        }
    }

    public void CharaDetailPanelFalse(){
        if(charaDetailPanel.activeSelf){
            charaDetailPanel.SetActive(false);
        }
        
    }
    public void CharaSelectPanelFalse(){
        if(charaSelectPanel.activeSelf){
            charaSelectPanel.SetActive(false);
        }
    }
    public void MonsterDetailPanelFalse(){
        if(monsterDetailPanel.activeSelf){
            monsterDetailPanel.SetActive(false);
        }
    }

    
}
