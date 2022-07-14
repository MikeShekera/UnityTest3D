using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FilesRead : MonoBehaviour
{
    private void Start()
    {
        string readFromFilePath = Application.dataPath + "/Resources/" + "data1" + ".txt";

        List<string> mergedList = File.ReadAllLines(readFromFilePath).ToList(); 

        foreach (var x in mergedList)
        {
            Debug.Log(x.ToString());
        }
    }
}
