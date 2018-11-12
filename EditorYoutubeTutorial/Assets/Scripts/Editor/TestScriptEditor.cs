using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestScript))]
public class TestScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        SerializedProperty integerProperty = serializedObject.FindProperty("integer");
        EditorGUILayout.PropertyField(integerProperty);

        SerializedProperty vectorProperty = serializedObject.FindProperty("vector3");
        EditorGUILayout.PropertyField(vectorProperty);

        SerializedProperty floatSliderProperty = serializedObject.FindProperty("sliderFloat");
        floatSliderProperty.floatValue = EditorGUILayout.Slider("Float Slider", floatSliderProperty.floatValue, 0, 2);

        SerializedProperty sStructProperty = serializedObject.FindProperty("sStruct");
        EditorGUILayout.PropertyField(sStructProperty);

        if (GUILayout.Button("Message"))
            ((TestScript)serializedObject.targetObject).Log("My message");

        serializedObject.ApplyModifiedProperties();
    }
}