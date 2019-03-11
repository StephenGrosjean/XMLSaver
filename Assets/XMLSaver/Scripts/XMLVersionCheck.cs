using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
/// <summary>
/// XMLSave Check version
/// </summary>
public class XMLVersionCheck : MonoBehaviour {

    //SINGLETON//
    public static XMLVersionCheck instance;

    private void Awake() {
        instance = this;
    }
    //END SINGLETON//


    void Start() {

        if (File.Exists(XMLSave.instance.dataPath + XMLSave.instance.nameFile)) {
            XMLSave.instance.Load();

            //Put the xml save in the latest update
            if (XMLSave.instance.dataBase.ApplicationVersion.Count > 0) {
                Debug.Log("Version present");
                if (XMLSave.instance.dataBase.ApplicationVersion[0].value.ToString() != Application.version) {
                    Debug.Log("Wrong version" + " Correct version : " + Application.version + " Found : " + XMLSave.instance.dataBase.ApplicationVersion[0].value.ToString());
                    float.TryParse(Application.version, out XMLSave.instance.dataBase.ApplicationVersion[0].value);
                    XMLSave.instance.Save();
                }
                else {
                    Debug.Log("Correct version");
                }
            }
            else {
                Debug.Log("Version not present");
                Version version = new Version();
                XMLSave.instance.dataBase.ApplicationVersion.Add(version);
                XMLSave.instance.dataBase.ApplicationVersion[0].name = "Version";
                float.TryParse(Application.version, out XMLSave.instance.dataBase.ApplicationVersion[0].value);
                XMLSave.instance.Save();
                Debug.Log("Added version");
            }
            VersionChanges();
        }
        else {
            Debug.Log("Created Database file");
            XMLSave.instance.Save();
        }
    }

    //Add changes to dataBase
    void VersionChanges() {
        XMLSave.instance.Load();
        


        XMLSave.instance.Save();
    }
}
