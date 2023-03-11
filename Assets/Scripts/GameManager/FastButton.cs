using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FastButton : MonoBehaviour
{
    private int fastButtonFlug=0;
    public Sprite fastButton;
    public Image fastButtonPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {}

    public void pushFastButton(){
        if(fastButtonFlug==0){
            fastButtonFlug=1;
            fastButtonPanel.sprite = fastButton;
            var c = fastButtonPanel.color;
            fastButtonPanel.color = new Color(0.5f, 1, 0.5f, 1);
        }
        else if(fastButtonFlug==1){
            fastButtonFlug=0;
            fastButtonPanel.sprite = fastButton;
            var c = fastButtonPanel.color;
            fastButtonPanel.color = new Color(1, 1, 1, 1);
        }
        
    }
    public int GetFastFlug(){
        return fastButtonFlug;
    }
}
