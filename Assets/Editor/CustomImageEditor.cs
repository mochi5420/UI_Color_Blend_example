﻿using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(CustomImage), true)]
[CanEditMultipleObjects]
public class CostomImageEditor : ImageEditor
{

    SerializedProperty _blendType;

    protected override void OnEnable()
    {
        _blendType = serializedObject.FindProperty("_blendType");
        base.OnEnable();
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        _blendType.intValue = (int)(CustomImage.BlendType)EditorGUILayout.EnumPopup("Blend Type", (CustomImage.BlendType)_blendType.intValue);

        serializedObject.ApplyModifiedProperties();

        base.OnInspectorGUI();
    }
}

