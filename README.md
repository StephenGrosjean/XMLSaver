# XMLSaver ![Version](https://img.shields.io/badge/Version-0.4-brightgreen.svg) ![UnityVersion](https://img.shields.io/badge/Unity-2019.3.7f1-blue.svg)

XMLSaver for unity


## Usage (v0.4)
Use the editor window to inititalize the XMLSave System (XMLSaver/inititalize) With or without the version check


##### Save XML file
```csharp
XMLSave.instance.Save();
```

##### Load XML file
```csharp
XMLSave.instance.Load();
XMLSave.instance.Load(string fileName);
```

##### Get Int
```csharp
XMLSave.instance.GetInt(string name);
```

##### Get Float
```csharp
XMLSave.instance.GetFloat(string name);
```

##### Get String
```csharp
XMLSave.instance.GetString(string name);
```

##### Get Vector2
```csharp
XMLSave.instance.GetVector2(string name);
```

##### Get Vector3
```csharp
XMLSave.instance.GetVector3(string name);
```


##### Set Int
```csharp
XMLSave.instance.GetInt(string name, int value);
```

##### Set Float
```csharp
XMLSave.instance.GetFloat(string name, float value);
```

##### Set String
```csharp
XMLSave.instance.GetString(string name, string value);
```

##### Set Vector2
```csharp
XMLSave.instance.GetVector2(string name, vector2 value);
```

##### Set Vector3
```csharp
XMLSave.instance.GetVector3(string name, vector3 value);
```



## Links
* [Version 0.4](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V04.unitypackage)

* [Version 0.3](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V03.unitypackage)

* [Version 0.2](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V02.unitypackage)

* [Version 0.1](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V01.unitypackage)


## Changelog
#### v0.4
+ Changed Find<Type> to Get<Type>
+ Added Set<Type> functions
+ Added load(string fileName)

#### v0.3
+ Added editor window to inititalize the XMLSaver

#### v0.2
+ Modified all the scripts to add functions to find specific data in the dataset
+ Added datapath depending on platform
+ Added multiple files for class (Cleaner code)

#### v0.1
+ First version, you can save data List in StreamingAssets
