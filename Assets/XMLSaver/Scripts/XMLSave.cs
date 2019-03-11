using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
/// <summary>
/// Made by Stephen Grosjean
/// V 0.2
/// </summary>

public class XMLSave : MonoBehaviour {

    //SINGLETON//
    public static XMLSave instance;

    private void Awake() {
        instance = this;
    }
    //END SINGLETON//

    //Variables
    [HideInInspector] public string nameFile = "/database.xml";
    [HideInInspector] public string dataPath;

    [Space(20)]
    //Database item
    public DataBase dataBase;

    private void Start() {
        CheckDataPath();
    }

    //Save function
    public void Save() {
        //open xml file
        XmlSerializer serializer = new XmlSerializer(typeof(DataBase));

        //Create Stream
        FileStream stream = new FileStream(dataPath + nameFile, FileMode.Create);

        //Serialize DB
        serializer.Serialize(stream, dataBase);

        //Close the stream
        stream.Close();
    }

    //Load function
    public void Load() {
        CheckDataPath();

        //open xml file
        XmlSerializer serializer = new XmlSerializer(typeof(DataBase));

        //Create Stream
        if (File.Exists(dataPath + nameFile)) {
            FileStream stream = new FileStream(dataPath + nameFile, FileMode.Open);

            //Deserialize DB
            dataBase = serializer.Deserialize(stream) as DataBase;

            //Close the stream
            stream.Close();
        }
        else {
            //Error message
            Debug.LogErrorFormat("<b><size=12><color=red>ERROR : File " + nameFile + " does not exist at path : </color><color=green> " + dataPath + nameFile + " </color> <color=red> (Maybe you did not save?) </color></size></b>");
        }
    }

    //Set the DataPath depending of the platform
    void CheckDataPath() {
        //iOS or Android
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
            dataPath = Application.persistentDataPath;
        }
        //Other
        else {
            dataPath = Application.streamingAssetsPath;
        }
    }

    public void FindInt(string name, out int result) {
        foreach (Int data in dataBase.IntDB) {
            if (data.name == name) {
                result = data.value;
                return;
            }
        }
        result = 0;
    }

    public void FindFloat(string name, out float result) {
        foreach (Float data in dataBase.FloatDB) {
            if (data.name == name) {
                result = data.value;
                return;
            }
        }
        result = 0;
    }

    public void FindString(string name, out string result) {
        foreach (String data in dataBase.StringDB) {
            if (data.name == name) {
                result = data.value;
                return;
            }
        }
        result = "";
    }

    public void FindVector2(string name, out Vector2 result) {
        foreach (Vector2D data in dataBase.Vector2DB) {
            if (data.name == name) {
                result = data.value;
                return;
            }
        }
        result = new Vector2(0,0);
    }

    public void FindVector3(string name, out Vector3 result) {
        foreach (Vector3D data in dataBase.Vector3DB) {
            if (data.name == name) {
                result = data.value;
                return;
            }
        }
        result = new Vector3(0, 0, 0);
    }

}




