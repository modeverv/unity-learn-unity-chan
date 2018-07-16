using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracker : MonoBehaviour {
  public Transform leftHand;
  public Transform rightHand;

  // Use this for initialization
  void Start () {
    if (leftHand == null) {
      leftHand = GameObject.Find("Character1_LeftHand").transform;
    }
    if (rightHand == null) {
      rightHand = GameObject.Find("Character1_RightHand").transform;
    }
  }
  
  // Update is called once per frame
  void Update () {
    if (Input.GetKey(KeyCode.A)) {
      rightHand.Translate(Vector3.left * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D)) {
      rightHand.Translate(Vector3.right * Time.deltaTime);      
    }
    if (Input.GetKey(KeyCode.S)) {
      rightHand.Translate(Vector3.back * Time.deltaTime);     
    }
    if (Input.GetKey(KeyCode.W)) {
      rightHand.Translate(Vector3.forward * Time.deltaTime);      
    }

    if (Input.GetKey(KeyCode.J)) {
      leftHand.Translate(Vector3.right * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.L)) {
      leftHand.Translate(Vector3.left * Time.deltaTime);      
    }
    if (Input.GetKey(KeyCode.K)) {
      leftHand.Translate(Vector3.forward * Time.deltaTime);     
    }
    if (Input.GetKey(KeyCode.I)) {
      leftHand.Translate(Vector3.back * Time.deltaTime);      
    }
  }
}
