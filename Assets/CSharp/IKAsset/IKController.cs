using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKController : MonoBehaviour {
  public Transform leftHandBlock;
  public Transform rightHandBlock;
  Animator animator;

  // Use this for initialization
  void Start () {
    animator = GetComponent<Animator>();
  }

  void OnAnimatorIK() {
    if (!animator) return;
    if (Input.GetMouseButton(0)) return;

    if (leftHandBlock) {
      animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
      animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
      animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandBlock.position);
      animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandBlock.rotation);
    }

    if (rightHandBlock) {
      animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
      animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
      animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandBlock.position);
      animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandBlock.rotation);
    }
  }
}
