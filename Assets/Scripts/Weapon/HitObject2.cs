// 剣用
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject2 : MonoBehaviour {
  private float dmg;

  void Start(){
    
  }
  // 当たった時に呼ばれる関数
  void OnCollisionEnter(Collision collision)
  {
    dmg=GetComponent<WeaponStatus>().GetDmg();
    collision.gameObject.GetComponent<MonsterStatus>().HitWeapon(dmg);
    // Debug.Log("Hit"); // ログを表示する
  }
}
