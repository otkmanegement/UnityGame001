using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseEnemy : MonoBehaviour
{
    private Camera cam;
    private float speed;
    private GameObject[] targets;
    private bool isSwitch = false;
    private GameObject closeEnemy;
    private RectTransform rect;
    private GameObject gameManager;

    private void Start(){
        cam=Camera.main;
        targets = GameObject.FindGameObjectsWithTag("Enemy");
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        speed=this.GetComponent<WeaponStatus>().move_speed;
        rect=this.GetComponent<RectTransform>();

        // 「初期値」の設定
        float closeDist = 10000;

        foreach (GameObject t in targets){
            float tDist = Vector3.Distance(GetWorldPositionFromRectPosition(rect), GetWorldPositionFromRectPosition(t.GetComponent<RectTransform>()));
            if(closeDist > tDist)
            {
                closeDist = tDist;
                closeEnemy = t;
            }
        }
        Invoke("SwitchOn", 0.1f);
    }

    void Update(){
        if(gameManager.GetComponent<PlayButton>().GetPlayFlug()==1){
            if (closeEnemy != null){
                if(isSwitch)
                {
                    float step = speed * Time.deltaTime;
                    rect.localPosition = Vector3.MoveTowards(rect.localPosition, closeEnemy.GetComponent<RectTransform>().localPosition, step);
                }
            }
            else{
                Start();
            }
        }
    }

    void SwitchOn(){
        isSwitch = true;
    }

    private Vector3 GetWorldPositionFromRectPosition(RectTransform rect)
    {
        //UI座標からスクリーン座標に変換
        Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(cam, rect.position);

        //ワールド座標
        Vector3 result = Vector3.zero;

        //スクリーン座標→ワールド座標に変換
        RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPos, cam, out result);

        return result;
    }
}