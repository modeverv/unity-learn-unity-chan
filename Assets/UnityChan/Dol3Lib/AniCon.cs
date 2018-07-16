using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dol3Lib {
  public class AniCon : MonoBehaviour {
    [System.Serializable]
    public class Shortcut {
      public KeyCode key;
      [Dol3Lib.AnimatorStateName()]
      public string stateName;
      public float speed = 1.0f;
    }

    [SerializeField]
    public Shortcut[] shortcuts;
    Animator animator;

    void Start () {
      animator = GetComponent<Animator>();
    }
    
    void Update () {
      foreach(Shortcut s in shortcuts) {
        if (Input.GetKeyDown(s.key)) {
          animator.speed = s.speed;
          animator.Play(s.stateName);
        }
      }
    }
  }
}
