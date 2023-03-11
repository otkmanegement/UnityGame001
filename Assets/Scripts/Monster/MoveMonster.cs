using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMonster : MonoBehaviour
{
    RectTransform rect;
    private GameObject gameManager;
    private int fastTime;
    // Start is called before the first frame update
    void Start()
    {
        rect=this.GetComponent<RectTransform>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
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
            // 上側の敵
            if(rect.localPosition.x<-90 && rect.localPosition.x>=-2000 && rect.localPosition.y==390){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>-90){
                    rect.localPosition = new Vector3(-90, 390, 0);
                }
            }

            else if(rect.localPosition.x==-90 && rect.localPosition.y>-150 && rect.localPosition.y<=390){
                rect.localPosition += new Vector3(0, -(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y<-150){
                    rect.localPosition = new Vector3(-90, -150, 0);
                }
            }

            else if(rect.localPosition.x<=-90 && rect.localPosition.x>-630 && rect.localPosition.y==-150){
                rect.localPosition += new Vector3(-(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x<-630){
                    rect.localPosition = new Vector3(-630, -150, 0);
                }
            }

            else if(rect.localPosition.x==-630 && rect.localPosition.y>-330 && rect.localPosition.y<=-150){
                rect.localPosition += new Vector3(0, -(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y<-330){
                    rect.localPosition = new Vector3(-630, -330, 0);
                }
            }

            else if(rect.localPosition.x>=-630 && rect.localPosition.x<90 && rect.localPosition.y==-330){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>90){
                    rect.localPosition = new Vector3(90, -330, 0);
                }
            }
            else if(rect.localPosition.x==90 && rect.localPosition.y<390 && rect.localPosition.y>=-330){
                rect.localPosition += new Vector3(0, +(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y>390){
                    rect.localPosition = new Vector3(90, 390, 0);
                }
            }
            else if(rect.localPosition.x<630 && rect.localPosition.x>=90 && rect.localPosition.y==390){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>630){
                    rect.localPosition = new Vector3(630, 390, 0);
                }
            }
            else if(rect.localPosition.x==630 && rect.localPosition.y==390){
                rect.localPosition = new Vector3(-990,390,0);
                gameManager.GetComponent<HpKeeper>().HpValueUpdate(-1);
            }
            // 下側の敵
            if(rect.localPosition.x<-150 && rect.localPosition.x>=-2000 && rect.localPosition.y==330){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>-150){
                    rect.localPosition = new Vector3(-150, 330, 0);
                }
            }

            else if(rect.localPosition.x==-150 && rect.localPosition.y>-90 && rect.localPosition.y<=330){
                rect.localPosition += new Vector3(0, -(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y<-90){
                    rect.localPosition = new Vector3(150, -90, 0);
                }
            }

            else if(rect.localPosition.x<=-150 && rect.localPosition.x>-690 && rect.localPosition.y==-90){
                rect.localPosition += new Vector3(-(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x<-690){
                    rect.localPosition = new Vector3(-690, -90, 0);
                }
            }

            else if(rect.localPosition.x==-690 && rect.localPosition.y>-390 && rect.localPosition.y<=-90){
                rect.localPosition += new Vector3(0, -(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y<-390){
                    rect.localPosition = new Vector3(-690, -390, 0);
                }
            }

            else if(rect.localPosition.x>=-690 && rect.localPosition.x<150 && rect.localPosition.y==-390){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>150){
                    rect.localPosition = new Vector3(150, -390, 0);
                }
            }
            else if(rect.localPosition.x==150 && rect.localPosition.y<330 && rect.localPosition.y>=-390){
                rect.localPosition += new Vector3(0, +(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y>330){
                    rect.localPosition = new Vector3(-150, 330, 0);
                }
            }
            else if(rect.localPosition.x<630 && rect.localPosition.x>=150 && rect.localPosition.y==330){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>630){
                    rect.localPosition = new Vector3(630, 330, 0);
                }
            }
            else if(rect.localPosition.x==630 && rect.localPosition.y==330){
                rect.localPosition = new Vector3(-990,330,0);
                gameManager.GetComponent<HpKeeper>().HpValueUpdate(-1);
            }
            // 中央の敵
            if(rect.localPosition.x<-120 && rect.localPosition.x>=-2000 && rect.localPosition.y==360){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>-120){
                    rect.localPosition = new Vector3(-120, 360, 0);
                }
            }

            else if(rect.localPosition.x==-120 && rect.localPosition.y>-120 && rect.localPosition.y<=360){
                rect.localPosition += new Vector3(0, -(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y<-120){
                    rect.localPosition = new Vector3(-120, -120, 0);
                }
            }

            else if(rect.localPosition.x<=-120 && rect.localPosition.x>-660 && rect.localPosition.y==-120){
                rect.localPosition += new Vector3(-(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>-120){
                    rect.localPosition = new Vector3(-660, -120, 0);
                }
            }

            else if(rect.localPosition.x==-660 && rect.localPosition.y>-360 && rect.localPosition.y<=-120){
                rect.localPosition += new Vector3(0, -(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y<-360){
                    rect.localPosition = new Vector3(-660, -360, 0);
                }
            }

            else if(rect.localPosition.x>=-660 && rect.localPosition.x<120 && rect.localPosition.y==-360){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>120){
                    rect.localPosition = new Vector3(120, -360, 0);
                }
            }
            else if(rect.localPosition.x==120 && rect.localPosition.y<360 && rect.localPosition.y>=-360){
                rect.localPosition += new Vector3(0, +(this.GetComponent<MonsterStatus>().speed*fastTime), 0);
                if(rect.localPosition.y>360){
                    rect.localPosition = new Vector3(120, 360, 0);
                }
            }
            else if(rect.localPosition.x<660 && rect.localPosition.x>=120 && rect.localPosition.y==360){
                rect.localPosition += new Vector3(+(this.GetComponent<MonsterStatus>().speed*fastTime), 0, 0);
                if(rect.localPosition.x>660){
                    rect.localPosition = new Vector3(660, 360, 0);
                }
            }
            else if(rect.localPosition.x==660 && rect.localPosition.y==360){
                rect.localPosition = new Vector3(-1020,360,0);
                gameManager.GetComponent<HpKeeper>().HpValueUpdate(-1);
            }
        }

    
        
    }
}
