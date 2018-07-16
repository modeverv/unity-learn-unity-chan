using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrackerWithIK : MonoBehaviour {
  public Transform leftHand;
  public Transform rightHand;

  // Use this for initialization
  void Start () {
  }
  
  // Update is called once per frame
  void LateUpdate () {
    if (Input.GetKey(KeyCode.A)) {
      rightHand.Translate(Vector3.left * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D)) {
      rightHand.Translate(Vector3.right * Time.deltaTime);      
    }
    if (Input.GetKey(KeyCode.S)) {
      rightHand.Translate(Vector3.down * Time.deltaTime);     
    }
    if (Input.GetKey(KeyCode.W)) {
      rightHand.Translate(Vector3.up * Time.deltaTime);     
    }
    if (Input.GetKey(KeyCode.Q)) {
      rightHand.Translate(Vector3.forward * Time.deltaTime);      
    }
    if (Input.GetKey(KeyCode.E)) {
      rightHand.Translate(Vector3.back * Time.deltaTime);     
    }

    if (Input.GetKey(KeyCode.J)) {
      leftHand.Translate(Vector3.left * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.L)) {
      leftHand.Translate(Vector3.right * Time.deltaTime);     
    }
    if (Input.GetKey(KeyCode.K)) {
      leftHand.Translate(Vector3.down * Time.deltaTime);      
    }
    if (Input.GetKey(KeyCode.I)) {
      leftHand.Translate(Vector3.up * Time.deltaTime);      
    }
    if (Input.GetKey(KeyCode.U)) {
      leftHand.Translate(Vector3.forward * Time.deltaTime);     
    }
    if (Input.GetKey(KeyCode.O)) {
      leftHand.Translate(Vector3.back * Time.deltaTime);      
    }
  }
}
