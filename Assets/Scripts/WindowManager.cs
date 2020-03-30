using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WindowManager : EditorWindow
{
    private GameObject Container;
    public string defaultString = "amountOfObjects";
    public string[] amountOfObjects, amountOfFloats, amountOfStrings;

    [MenuItem("Window/Universal Sorter")]
    public static void ShowWindow()
    {
        GetWindow<WindowManager>("Universal Sorter");
    }

    private void OnGUI()
    {
        GUILayout.Label("Choose algorithm", EditorStyles.boldLabel);

        if (GUILayout.Button("Quick Sort"))
        {
            //What happen after clicking the button
        }

        if (GUILayout.Button("Bubble Sort"))
        {
            //What happen after clicking the button
        }

        if (GUILayout.Button("Simple Sort"))
        {
            //What happen after clicking the button
        }


        //Show Label (line) in the style
        GUILayout.Label("Spawn primitives", EditorStyles.boldLabel);

        GUILayout.Label("Choose variable type");

        if (GUILayout.Button("Object"))
        {
            //What happen after clicking the button
        }

        if (GUILayout.Button("Float"))
        {
            //What happen after clicking the button
        }

        if (GUILayout.Button("String"))
        {
            //What happen after clicking the button
        }

        GUILayout.Label("Choose amount of variables");

        ScriptableObject target = this;
        SerializedObject so = new SerializedObject(target);
        SerializedProperty stringsProperty = so.FindProperty(defaultString);
        EditorGUILayout.PropertyField(stringsProperty, true);
        so.ApplyModifiedProperties();

        if (GUILayout.Button("SPAWN"))
        {
            if (Container == null)
            {
                Container = new GameObject("Container");
            }

            for (int i = 0; i < amountOfObjects.Length; i++)
            {
                GameObject.CreatePrimitive(PrimitiveType.Capsule).transform.SetParent(Container.transform);
            }
        }
    }
}