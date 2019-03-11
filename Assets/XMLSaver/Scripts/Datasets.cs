using System.Collections.Generic;
using UnityEngine;

//Int Data types
[System.Serializable]
public class Int {
    public string name;
    public int value;
}

//Float Data types
[System.Serializable]
public class Float {
    public string name;
    public float value;
}

//String type info
[System.Serializable]
public class String {
    public string name;
    public string value;
}

//Vector2 type info
[System.Serializable]
public class Vector2D {
    public string name;
    public Vector2 value;
}

//Vector3 type info
[System.Serializable]
public class Vector3D {
    public string name;
    public Vector3 value;
}

//Version info
[System.Serializable]
public class Version {
    public string name = "Version";
    public float value;
}

