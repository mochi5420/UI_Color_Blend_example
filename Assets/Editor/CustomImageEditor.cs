using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(CustomImage), true)]
[CanEditMultipleObjects]
public class CostomImageEditor : ImageEditor
{

    SerializedProperty _colorType;

    protected override void OnEnable()
    {
        _colorType = serializedObject.FindProperty("_colorType");
        base.OnEnable();
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        _colorType.intValue = (int)(CustomImage.TYPE)EditorGUILayout.EnumPopup("Type", (CustomImage.TYPE)_colorType.intValue);

        serializedObject.ApplyModifiedProperties();

        base.OnInspectorGUI();
    }
}

