using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Dol3Lib {
  public class AnimatorStateNameAttribute : PropertyAttribute {
  }

  [CustomPropertyDrawer (typeof(AnimatorStateNameAttribute))]
  public class AnimatorStateNameDrawer : PropertyDrawer {
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
      AniCon anicon = property.serializedObject.targetObject as AniCon;
      Animator animator = anicon.GetComponentInParent<Animator>();
      UnityEditor.Animations.AnimatorController ac = animator.runtimeAnimatorController as UnityEditor.Animations.AnimatorController;
      List<string> states = new List<string>();
      foreach(UnityEditor.Animations.ChildAnimatorState s in ac.layers[0].stateMachine.states) {
        states.Add(s.state.name);
      }

      int selected = 0;
      if (property.stringValue != null && states.IndexOf(property.stringValue) >= 0) {
        selected = states.IndexOf(property.stringValue);
      }

      property.stringValue = states[EditorGUI.Popup(position, "State", selected, states.ToArray())];
    }
  }
}
