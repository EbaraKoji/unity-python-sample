using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Scripting.Python;

public class PythonManager : MonoBehaviour
{
    void Start()
    {
        string path = $"{Application.dataPath}/PythonScripts/hello.py";
        PythonRunner.RunFile(path);
    }
}
