using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FilesRead : MonoBehaviour
{
    public GameObject button;

    public List<double> sortedList = new List<double>();
    public IEnumerable<string> list1;
    public IEnumerable<string> list2;
    public IEnumerable<string> mergedList;
    private string readFromFilePath;
    private string readFromFilePath2;

    public void FilesProcessing()
    {
        readFromFilePath = Application.dataPath + "/Resources/" + "data1" + ".txt";
        readFromFilePath2 = Application.dataPath + "/Resources/" + "data2" + ".txt";

        list1 = File.ReadAllLines(readFromFilePath);
        list2 = File.ReadAllLines(readFromFilePath2);

        mergedList = list1.Union<string>(list2);

        try
        {
            sortedList = mergedList.Select(double.Parse).ToList();
            Debug.Log("����������� �������");
        }
        catch (FormatException)
        {
            Debug.Log("������! � �������� ������ ���������� �� ������ ����� \n �������� ���������� ��������� ������");
            Application.Quit();
        }
        sortedList.Sort();
    }
}
