using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
/// <summary>
/// XMLSave editor window
/// </summary>
public class XMLSaverEditor : EditorWindow
{

    public GameObject xmlSave, xmlCheck;

    //Set the window parameters
    [MenuItem("XMLSaver/Initializer")]
    public static void ShowWindow() {
        GetWindow<XMLSaverEditor>(true, "XMLSaver", true);
        GetWindow<XMLSaverEditor>().minSize = new Vector2(300, 100);
        GetWindow<XMLSaverEditor>().maxSize = new Vector2(300, 100);
    }

    //Draw buttons
    private void OnGUI() {
        GUILayout.Label("XMLSaver", EditorStyles.boldLabel);

        //Spawn only XMLSave System
        if (GUILayout.Button("Basic Save System")) {
            if (!GameObject.Find("XMLSave")) {
                GameObject saveSystem = Instantiate(xmlSave);
                saveSystem.name = "XMLSave";
                Debug.Log("Created XMLSave");
            }
            else {
                Debug.LogError("XMLSave already exist");
            }
        }

        //Spawn XMLSave and XMLChecker
        if (GUILayout.Button("Advanced Save System")) {
            if (!GameObject.Find("XMLSave")) {
                GameObject saveSystem = Instantiate(xmlSave);
                saveSystem.name = "XMLSave";
                Debug.Log("Created XMLSave");
            }
            else {
                Debug.LogError("XMLSave already exist");
            }

            if (!GameObject.Find("XMLVersionCheck")) {
                GameObject checkSystem = Instantiate(xmlCheck);
                checkSystem.name = "XMLVersionCheck";
                Debug.Log("Created XMLVersionCheck");

            }
            else {
                Debug.LogError("XMLVersionCheck already exist");
            }

        }

    }
}