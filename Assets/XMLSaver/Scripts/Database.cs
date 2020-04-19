using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

//What to save 
[System.Serializable]
public class DataBase {

    [XmlArray("Int")] //Name in XML file (avoid spaces)
    public List<XML_Int> IntDB = new List<XML_Int>(); //Class to save

    [XmlArray("Float")]
    public List<XML_Float> FloatDB = new List<XML_Float>();

    [XmlArray("String")]
    public List<XML_String> StringDB = new List<XML_String>();

    [XmlArray("Vector2D")]
    public List<XML_Vector2D> Vector2DB = new List<XML_Vector2D>();

    [XmlArray("Vector3D")]
    public List<XML_Vector3D> Vector3DB = new List<XML_Vector3D>();

    [XmlArray("Version")]
    public List<Version> ApplicationVersion = new List<Version>();
}

