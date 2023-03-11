using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStatus : MonoBehaviour
{
    private GameObject gameManager;
    public string charaName;
    public float dmg;
    public float move_speed=100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetDmg(){
        return dmg;
    }
    public void ChangeDamage(float d){
        dmg=d;
    }
    public void ChangeSpeed(float s){
        move_speed=s;
    }
}
