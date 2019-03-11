using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleScript : MonoBehaviour
{
    //Exemple Variables
    [SerializeField] private string intName;
    [SerializeField] private int intValue;
    [Space(20)]

    [SerializeField] private string floatName;
    [SerializeField] private float floatValue;
    [Space(20)]

    [SerializeField] private string stringName;
    [SerializeField] private string stringValue;
    [Space(20)]

    [SerializeField] private string vector2Name;
    [SerializeField] private Vector2 vector2Value;
    [Space(20)]

    [SerializeField] private string vector3Name;
    [SerializeField] private Vector3 vector3Value;

    //Find variable by name and data type
    public void Find() {
        XMLSave.instance.FindInt(intName, out intValue);

        XMLSave.instance.FindFloat(floatName, out floatValue);

        XMLSave.instance.FindString(stringName, out stringValue);

        XMLSave.instance.FindVector2(vector2Name, out vector2Value);

        XMLSave.instance.FindVector3(vector3Name, out vector3Value);
    }
}
