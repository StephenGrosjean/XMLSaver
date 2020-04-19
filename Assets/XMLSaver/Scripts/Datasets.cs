using System.Collections.Generic;
using UnityEngine;

//Int Data types
[System.Serializable]
public class XML_Int {
    public string name;
    public int value;
}

//Float Data types
[System.Serializable]
public class XML_Float {
    public string name;
    public float value;
}

//String type info
[System.Serializable]
public class XML_String {
    public string name;
    public string value;
}

//Vector2 type info
[System.Serializable]
public class XML_Vector2D {
    public string name;
    public Vector2 value;
}

//Vector3 type info
[System.Serializable]
public class XML_Vector3D {
    public string name;
    public Vector3 value;
}

//Version info
[System.Serializable]
public class Version {
    public string name = "Version";
    public float value;
}

