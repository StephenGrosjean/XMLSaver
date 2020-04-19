using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
/// <summary>
/// Made by Stephen Grosjean
/// V 0.4
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
    public void Load(string fileName) {
        CheckDataPath();

        //open xml file
        XmlSerializer serializer = new XmlSerializer(typeof(DataBase));

        //Create Stream
        if (File.Exists(dataPath + fileName)) {
            FileStream stream = new FileStream(dataPath + fileName, FileMode.Open);

            //Deserialize DB
            dataBase = serializer.Deserialize(stream) as DataBase;

            //Close the stream
            stream.Close();
        }
        else {
            //Error message
            Debug.LogErrorFormat("<b><size=12><color=red>ERROR : File " + fileName + " does not exist at path : </color><color=green> " + dataPath + fileName + " </color> <color=red> (Maybe you did not save?) </color></size></b>");
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

    //GET
    public int GetInt(string name) {
        foreach (XML_Int data in dataBase.IntDB) {
            if (data.name == name) {
                return data.value;
            }
        }
        return 0;
    }

    public float GetFloat(string name) {
        foreach (XML_Float data in dataBase.FloatDB) {
            if (data.name == name) {
                return data.value;
            }
        }
        return 0;
    }

    public string GetString(string name) {
        foreach (XML_String data in dataBase.StringDB) {
            if (data.name == name) {
                return data.value;
            }
        }
        return "";
    }

    public Vector2 GetVector2(string name) {
        foreach (XML_Vector2D data in dataBase.Vector2DB) {
            if (data.name == name) {
                return data.value;
            }
        }
        return new Vector2(0, 0);
    }

    public Vector3 GetVector3(string name) {
        foreach (XML_Vector3D data in dataBase.Vector3DB) {
            if (data.name == name) {
                return data.value;
            }
        }
        return new Vector3(0, 0, 0);
    }


    //SET
    public void SetInt(string name, int value) {
        foreach (XML_Int data in dataBase.IntDB) {
            if (data.name == name) {
                data.value = value;
                return;
            }
        }
    }

    public void SetFloat(string name, float value) {
        foreach (XML_Float data in dataBase.FloatDB) {
            if (data.name == name) {
                data.value = value;
                return;
            }
        }
    }

    public void SetString(string name, string value) {
        foreach (XML_String data in dataBase.StringDB) {
            if (data.name == name) {
                data.value = value;
                return;
            }
        }
    }

    public void SetVector2(string name, Vector2 value) {
        foreach (XML_Vector2D data in dataBase.Vector2DB) {
            if (data.name == name) {
                data.value = value;
                return;
            }
        }
    }

    public void SetVector3(string name, Vector3 value) {
        foreach (XML_Vector3D data in dataBase.Vector3DB) {
            if (data.name == name) {
                data.value = value;
                return;
            }
        }
    }

}




