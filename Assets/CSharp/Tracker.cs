using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour {
  public GameObject character; // 制御したいHumanoidなモデルを指定。未指定時はunitychanになります。
  HeadLookController headLookController;
  public float yOffset = 0.5f;
  float r = 1.0f;

  void Start () {
    // モデル未指定時にはunitychanを探します。
    if (character == null) {
      character = GameObject.Find("unitychan");
    }
    headLookController = character.GetComponent<HeadLookController>();
  }
  
  void Update () {
    // マウス座標からビューポート座標を出し、注視点の座標を計算します。
    // X座標によってXZ平面の360度を決定し、Y座標によって高さを決定します。
    // yOffsetを変更することで基準となる高さを変更します。
    // マウスホイール(Y軸)で、キャラクタからの注視点の半径を制御します。
    if (!Camera.current) return;
    Vector3 vp = Camera.current.ScreenToViewportPoint(Input.mousePosition);
    float d = 90 + vp.x * 360;
    Vector3 target = new Vector3(Mathf.Cos(Mathf.Deg2Rad * d) * r, 0, Mathf.Sin(Mathf.Deg2Rad * d) * r);
    target.x += character.transform.position.x;
    target.z += character.transform.position.z;
    r += Input.mouseScrollDelta.y / 100.0f;

    target.y = yOffset + vp.y;
    
    headLookController.target = target;
    transform.position = target;
  }
}
