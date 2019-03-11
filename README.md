# XMLSaver ![Version](https://img.shields.io/badge/Version-0.3-brightgreen.svg) ![UnityVersion](https://img.shields.io/badge/Unity-2018.3.6f1-blue.svg)

XMLSaver for unity


## Usage (v0.3)
Use the editor window to inititalize the XMLSave System (XMLSaver/inititalize)

##### Save XML file
```csharp
XMLSave.instance.Save();
```

##### Load XML file
```csharp
XMLSave.instance.Load();
```

##### Find Int
```csharp
XMLSave.instance.FindInt(string name, out int result);
```

##### Find Float
```csharp
XMLSave.instance.FindFloat(string name, out float result);
```

##### Find String
```csharp
XMLSave.instance.FindString(string name, out string result);
```

##### Find Vector2
```csharp
XMLSave.instance.FindVector2(string name, out Vector2 result);
```

##### Find Vector3
```csharp
XMLSave.instance.FindVector3(string name, out Vector3 result);
```

## Links
* [Version 0.3](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V03.unitypackage)

* [Version 0.2](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V02.unitypackage)

* [Version 0.1](https://github.com/StephenGrosjean/XMLSaver/blob/master/Assets/PackageBuild/V01.unitypackage)


## Changelog
#### v0.3
+ Added editor window to inititalize the XMLSaver

### v0.2
+ Modified all the scripts to add functions to find specific data in the dataset
+ Added datapath depending on platform
+ Added multiple files for class (Cleaner code)

#### v0.1
+ First version, you can save data List in StreamingAssets
