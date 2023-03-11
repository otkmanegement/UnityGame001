using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour
{
    private GameObject canvas;
    private Camera cam;
    public GameObject sword;
    private GameObject gameManager;
    // public GameObject parent;
    private Transform parent;
    private RectTransform rect;
    private GameObject[] targets;
    private GameObject closeEnemy;
    private int count;
    private int startAttack=0;
    private int fastTime=1;
    // Start is called before the first frame update
    void Start()
    {
        cam=Camera.main;
        rect=this.GetComponent<RectTransform>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        targets = GameObject.FindGameObjectsWithTag("Enemy");
        canvas = GameObject.FindGameObjectWithTag("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.GetComponent<FastButton>().GetFastFlug()==1){
            fastTime=2;
        }
        else if(gameManager.GetComponent<FastButton>().GetFastFlug()==0){
            fastTime=1;
        }
        if(gameManager.GetComponent<PlayButton>().GetPlayFlug()==1){
            if(this.GetComponent<CharaSet>().charaNum==2){
                count += 1;
                targets = GameObject.FindGameObjectsWithTag("Enemy");
                float closeDist = 10000;
                foreach (GameObject t in targets){
                    if (t != null){
                        float tDist = Vector3.Distance(GetWorldPositionFromRectPosition(rect), GetWorldPositionFromRectPosition(t.GetComponent<RectTransform>()));
                        if(closeDist > tDist){
                            closeDist = tDist;
                        }
                    }                   
                }
                if(count % Mathf.Round(this.GetComponent<PanelStatus>().GetInterval()/fastTime) == 0)
                {
                    
                    if(closeDist<this.GetComponent<PanelStatus>().GetRound()){
                        if(startAttack==0){
                            startAttack +=1;
                        }
                        Attack();
                    }

                }
                else if(startAttack==0){
                    if(closeDist<this.GetComponent<PanelStatus>().GetRound()){
                        count=0;
                        startAttack +=1;
                        Attack();   
                    }

                }
            }
        }    
    }
    void Attack(){
        Instantiate(sword,GetWorldPositionFromRectPosition(rect),Quaternion.identity,canvas.transform);
        // fire.GetComponent<RectTransform>().localPosition=new Vector3(rect.localPosition.x,rect.localPosition.y,0);
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
