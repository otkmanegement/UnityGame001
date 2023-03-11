using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterStatus : MonoBehaviour
{
    public float maxHp;
    private float currentHp;
    public float speed;
    public int reward=5;
    public Slider slider;
    private GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        currentHp=maxHp;
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update(){
        slider.value = currentHp / maxHp;
        if(currentHp<=0){
            Destroy(this.gameObject);
            gameManager.GetComponent<MoneyKeeper>().MoneyCalc(reward);
            gameManager.GetComponent<MoneyKeeper>().MoneyValueUpdate();
        }
    }

    public void HitWeapon(float dmg){
        currentHp-=dmg;
    }
}
