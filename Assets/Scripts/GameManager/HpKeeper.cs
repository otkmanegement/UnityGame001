using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpKeeper : MonoBehaviour
{
    public Text hpValueText;
    public int maxHp;
    private int currentHp;
    // Start is called before the first frame update
    void Start()
    {
        currentHp=maxHp;
        hpValueText.text=currentHp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHp<1){
            SceneManager.LoadScene("GameOver");
        }
    }
    public void HpValueUpdate(int x){
        currentHp+=x;
        hpValueText.text=currentHp.ToString();
    }
}
