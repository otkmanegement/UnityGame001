using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAttacker : MonoBehaviour
{
    private GameObject[] attackers;
    private GameObject closeAttacker;
    private RectTransform rect;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam=Camera.main;
        attackers = GameObject.FindGameObjectsWithTag("Attacker");
        rect=this.GetComponent<RectTransform>();
        float closeDist = 10000;
        foreach (GameObject t in attackers){
            float tDist = Vector3.Distance(GetWorldPositionFromRectPosition(rect), GetWorldPositionFromRectPosition(t.GetComponent<RectTransform>()));
            if(closeDist > tDist)
            {
                closeDist = tDist;
                closeAttacker = t;
            }
        }
        this.GetComponent<WeaponStatus>().ChangeDamage(closeAttacker.GetComponent<PanelStatus>().GetAt());
    }

    // Update is called once per frame
    void Update()
    {
        
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
