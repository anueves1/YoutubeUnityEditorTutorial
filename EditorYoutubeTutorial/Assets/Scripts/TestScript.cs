using UnityEngine;

[ExecuteInEditMode]
public class TestScript : MonoBehaviour
{
    [SerializeField]
    private int integer;

    [SerializeField]
    private Vector3 vector3;

    [SerializeField]
    private float sliderFloat;

    [SerializeField]
    private SerializedStruct sStruct;

    public void Log(string msg) => Debug.Log(msg);

    [ContextMenu("Log")]
    public void LogTwo() => Debug.Log("Context");

    private void Update()
    {
        sliderFloat += 0.01f;

        if (sliderFloat >= 2)
            sliderFloat -= 2;
    }
}

[System.Serializable]
public struct SerializedStruct
{
    [SerializeField]
    private int structInt;

    [SerializeField]
    private float structSliderFloat;
}