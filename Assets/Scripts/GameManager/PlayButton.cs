using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Sprite playButton;
    public Sprite stopButton;
    public Image playButtonPanel;
    private int playFlug=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pushPlayButton(){
        if(playFlug==0){
            playFlug=1;
            playButtonPanel.sprite = stopButton;
            var c = playButtonPanel.color;
            playButtonPanel.color = new Color(1, 1, 1, 1);
        }
        else if(playFlug==1){
            playFlug=0;
            playButtonPanel.sprite = playButton;
            var c = playButtonPanel.color;
            playButtonPanel.color = new Color(1, 1, 1, 1);
        }
        
    }

    public int GetPlayFlug(){
        return playFlug;
    }
}
