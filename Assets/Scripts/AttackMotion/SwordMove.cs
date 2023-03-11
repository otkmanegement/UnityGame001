using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMove : MonoBehaviour
{
    private RectTransform rect;
    private Camera cam;
    private GameObject[] targets;
    private GameObject closeEnemy;
    private int c;
    // Start is called before the first frame update
    void Start()
    {
        c=0;
        rect=this.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rect.eulerAngles += new Vector3( 0f, 0f, -30f);
        c+=30;
        if(c>=360){
            Destroy(this.gameObject);
        }
    }
}
