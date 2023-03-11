using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveChange : MonoBehaviour
{
    public GameObject charaDetailPanel;
    public GameObject charaSelectPanel;
    // Start is called before the first frame update
    void Start()
    {
        CharaDetailPanelFalse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharaDetailPanelTrue(){
        charaDetailPanel.SetActive(true);
    }
    public void CharaSelectPanelTrue(){
        charaSelectPanel.SetActive(true);
    }
    public void CharaDetailPanelFalse(){
        charaDetailPanel.SetActive(false);
    }
    public void CharaSelectPanelFalse(){
        charaSelectPanel.SetActive(false);
    }
}
