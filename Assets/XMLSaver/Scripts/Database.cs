using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

//What to save 
[System.Serializable]
public class DataBase {

    [XmlArray("Int")] //Name in XML file (avoid spaces)
    public List<Int> IntDB = new List<Int>(); //Class to save

    [XmlArray("Float")]
    public List<Float> FloatDB = new List<Float>();

    [XmlArray("String")]
    public List<String> StringDB = new List<String>();

    [XmlArray("Vector2D")]
    public List<Vector2D> Vector2DB = new List<Vector2D>();

    [XmlArray("Vector3D")]
    public List<Vector3D> Vector3DB = new List<Vector3D>();

    [XmlArray("Version")]
    public List<Version> ApplicationVersion = new List<Version>();
}

