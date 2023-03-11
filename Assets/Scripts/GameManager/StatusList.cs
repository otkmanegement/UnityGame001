using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusList : MonoBehaviour
{
    // wizard
    public int costWizard=100;
    public float atWizard=100;
    public float intervalWizard=100;
    public float roundWizard=10;

    // knight
    public int costKnight=20;
    public float atKnight=20;
    public float intervalKnight=60;
    public float roundKnight=2;

    // kunoiti
    public int costKunoiti=40;
    public float atKunoiti=5;
    public float intervalKunoiti=40;
    public float roundKunoiti=4;

    public int GetCost(string name){
        if(name=="wizard"){
            return costWizard;
        }
        else if(name=="knight"){
            return costKnight;
        }
        else if(name=="kunoiti"){
            return costKunoiti;
        }
        else{
            return 0;
        }
        
    }

    public float GetAt(string name){
        if(name=="wizard"){
            return atWizard;
        }
        else if(name=="knight"){
            return atKnight;
        }
        else if(name=="kunoiti"){
            return atKunoiti;
        }
        else{
            return 0;
        }
        
    }

    public float GetInterval(string name){
        if(name=="wizard"){
            return intervalWizard;
        }
        else if(name=="knight"){
            return intervalKnight;
        }
        else if(name=="kunoiti"){
            return intervalKunoiti;
        }
        else{
            return 0;
        }
        
    }
    public float GetRound(string name){
        if(name=="wizard"){
            return roundWizard;
        }
        else if(name=="knight"){
            return roundKnight;
        }
        else if(name=="kunoiti"){
            return roundKunoiti;
        }
        else{
            return 0;
        }
        
    }
}
