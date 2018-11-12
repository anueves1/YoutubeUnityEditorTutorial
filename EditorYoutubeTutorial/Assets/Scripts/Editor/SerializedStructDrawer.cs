using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(SerializedStruct))]
public class SerializedStructDrawer : PropertyDrawer
{
    int lines = 3;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        lines = 3;

        float ySpace = EditorGUIUtility.singleLineHeight + 2;

        position.y += ySpace;
        position.height = EditorGUIUtility.singleLineHeight;

        SerializedProperty structIntProperty = property.FindPropertyRelative("structInt");
        EditorGUI.PropertyField(position, structIntProperty);

        position.y += ySpace;

        SerializedProperty structSliderFloatProperty = property.FindPropertyRelative("structSliderFloat");
        EditorGUI.PropertyField(position, structSliderFloatProperty);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return (EditorGUIUtility.singleLineHeight + 2) * lines;
    }
}