using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.TerrainTools;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{

    public override void OnInspectorGUI()
    {
        Car myTarge = (Car)target;
        myTarge.speed= EditorGUILayout.IntField("Aceleração: ", myTarge.speed);        
        myTarge.gear = EditorGUILayout.IntField("Marcha: ", myTarge.gear);        

        EditorGUILayout.LabelField("Velocidade Total", myTarge.TotalSpeed().ToString());
    }

}
