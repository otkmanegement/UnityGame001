using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveKeeper : MonoBehaviour
{
    private int waveCount;
    public Text waveCountValue;
    public Text monsterHp;
    public Text monsterSpeed;
    public Text monsterReward;
    private GameObject wave1;
    private GameObject wave2;
    private GameObject wave3;
    private GameObject wave4;
    private GameObject wave5;
    private GameObject wave6;
    private GameObject wave7;
    private GameObject wave8;
    private GameObject wave9;
    private GameObject wave10;
    private GameObject wave11;
    private GameObject wave12;
    private GameObject wave13;
    private GameObject wave14;
    private GameObject wave15;
    private GameObject wave16;
    private GameObject wave17;
    private GameObject wave18;
    private GameObject wave19;
    private GameObject wave20;
    public Image monsterPanel;
    public Sprite monster1;
    public Sprite monster2;
    public Sprite monster3;
    public Sprite monster4;
    public Sprite monster5;
    public Sprite monster6;
    public Sprite monster7;
    public Sprite monster8;
    public Sprite monster9;
    public Sprite monster10;
    // private GameObject wave4;
    
    // Start is called before the first frame update
    void Start()
    {
        monsterPanel.sprite = monster1;
        var c = monsterPanel.color;
        monsterPanel.color = new Color(1, 1, 1, 1);
        monsterHp.text="10";
        monsterSpeed.text="1";
        monsterReward.text="5";
        waveCount=1;
        waveCountValue.text=waveCount.ToString();
        wave1 = GameObject.FindGameObjectWithTag("Wave1");
        wave2 = GameObject.FindGameObjectWithTag("Wave2");
        wave3 = GameObject.FindGameObjectWithTag("Wave3");
        wave4 = GameObject.FindGameObjectWithTag("Wave4");
        wave5 = GameObject.FindGameObjectWithTag("Wave5");
        wave6 = GameObject.FindGameObjectWithTag("Wave6");
        wave7 = GameObject.FindGameObjectWithTag("Wave7");
        wave8 = GameObject.FindGameObjectWithTag("Wave8");
        wave9 = GameObject.FindGameObjectWithTag("Wave9");
        wave10 = GameObject.FindGameObjectWithTag("Wave10");
        // wave11 = GameObject.FindGameObjectWithTag("Wave11");
        // wave12 = GameObject.FindGameObjectWithTag("Wave12");
        // wave13 = GameObject.FindGameObjectWithTag("Wave13");
        // wave14 = GameObject.FindGameObjectWithTag("Wave14");
        // wave15 = GameObject.FindGameObjectWithTag("Wave15");
        // wave16 = GameObject.FindGameObjectWithTag("Wave16");
        // wave17 = GameObject.FindGameObjectWithTag("Wave17");
        // wave18 = GameObject.FindGameObjectWithTag("Wave18");
        // wave19 = GameObject.FindGameObjectWithTag("Wave19");
        // wave20 = GameObject.FindGameObjectWithTag("Wave20");

        wave2.SetActive (false);
        wave3.SetActive (false);
        wave4.SetActive (false);
        wave4.SetActive (false);
        wave5.SetActive (false);
        wave6.SetActive (false);
        wave7.SetActive (false);
        wave8.SetActive (false);
        wave9.SetActive (false);
        wave10.SetActive (false);
        // wave11.SetActive (false);
        // wave12.SetActive (false);
        // wave13.SetActive (false);
        // wave14.SetActive (false);
        // wave14.SetActive (false);
        // wave15.SetActive (false);
        // wave16.SetActive (false);
        // wave17.SetActive (false);
        // wave18.SetActive (false);
        // wave19.SetActive (false);
        // wave20.SetActive (false);

    }

    // Update is called once per frame
    void Update()
    {
        if(waveCount==1){
            if(wave1.transform.childCount==0){
                monsterPanel.sprite = monster2;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="20";
                monsterSpeed.text="1";
                monsterReward.text="8";
                Destroy(wave1);
                wave2.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==2){
            if(wave2.transform.childCount==0){
                monsterPanel.sprite = monster3;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="20";
                monsterSpeed.text="3";
                monsterReward.text="8";
                Destroy(wave2);
                wave3.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==3){
            if(wave3.transform.childCount==0){
                monsterPanel.sprite = monster4;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="40";
                monsterSpeed.text="1";
                monsterReward.text="10";
                Destroy(wave3);
                wave4.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==4){
            if(wave4.transform.childCount==0){
                monsterPanel.sprite = monster5;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="60";
                monsterSpeed.text="1";
                monsterReward.text="15";
                Destroy(wave4);
                wave5.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==5){
            if(wave5.transform.childCount==0){
                monsterPanel.sprite = monster6;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="120";
                monsterSpeed.text="2";
                monsterReward.text="20";
                Destroy(wave5);
                wave6.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==6){
            if(wave6.transform.childCount==0){
                monsterPanel.sprite = monster7;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="240";
                monsterSpeed.text="2";
                monsterReward.text="20";
                Destroy(wave6);
                wave7.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==7){
            if(wave7.transform.childCount==0){
                monsterPanel.sprite = monster8;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="360";
                monsterSpeed.text="1";
                monsterReward.text="20";
                Destroy(wave7);
                wave8.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==8){
            if(wave8.transform.childCount==0){
                monsterPanel.sprite = monster9;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="480";
                monsterSpeed.text="2";
                monsterReward.text="30";
                Destroy(wave8);
                wave9.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==9){
            if(wave9.transform.childCount==0){
                monsterPanel.sprite = monster10;
                var c = monsterPanel.color;
                monsterPanel.color = new Color(1, 1, 1, 1);
                monsterHp.text="600";
                monsterSpeed.text="2";
                monsterReward.text="50";
                Destroy(wave9);
                wave10.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==10){
            if(wave10.transform.childCount==0){
                Destroy(wave10);
                SceneManager.LoadScene("GameClear");
            }
            // if(wave10.transform.childCount==0){
            //     Destroy(wave10);
            //     wave11.SetActive (true);
            //     waveCount+=1;
            //     WaveTextUpdate();
            // }
        }
        if(waveCount==11){
            if(wave11.transform.childCount==0){
                Destroy(wave11);
                wave12.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==12){
            if(wave12.transform.childCount==0){
                Destroy(wave12);
                wave13.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==13){
            if(wave13.transform.childCount==0){
                Destroy(wave13);
                wave14.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==14){
            if(wave14.transform.childCount==0){
                Destroy(wave14);
                wave15.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==15){
            if(wave15.transform.childCount==0){
                Destroy(wave15);
                wave16.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==16){
            if(wave16.transform.childCount==0){
                Destroy(wave16);
                wave17.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }if(waveCount==17){
            if(wave17.transform.childCount==0){
                Destroy(wave17);
                wave18.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==18){
            if(wave18.transform.childCount==0){
                Destroy(wave18);
                wave19.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==19){
            if(wave19.transform.childCount==0){
                Destroy(wave19);
                wave20.SetActive (true);
                waveCount+=1;
                WaveTextUpdate();
            }
        }
        if(waveCount==20){
            if(wave20.transform.childCount==0){
                Destroy(wave20);
                SceneManager.LoadScene("GameClear");
            }
        }
        
    }
    public void WaveTextUpdate(){
        waveCountValue.text=waveCount.ToString()+"/20";
    }
}
