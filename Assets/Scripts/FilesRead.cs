using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FilesRead : MonoBehaviour
{
    public static List<double> sortedList = new List<double>();
    public static List<string> mergedList = new List<string>();
    public void Start()
    {
        string readFromFilePath = Application.dataPath + "/Resources/" + "data1" + ".txt";
        string readFromFilePath2 = Application.dataPath + "/Resources/" + "data2" + ".txt";

        List<string> list1 = File.ReadAllLines(readFromFilePath).ToList();
        List<string> list2 = File.ReadAllLines(readFromFilePath2).ToList();
        //List<string> mergedList = new List<string>();
        mergedList = new List<string>();
        mergedList = list1.Union<string>(list2).ToList<string>();
        sortedList = mergedList.Select(double.Parse).ToList();
        sortedList.Sort();

        foreach (var x in sortedList)
        {
            Debug.Log(x.ToString());
        }
    }
}
