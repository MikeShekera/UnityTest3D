using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class FilesRead : MonoBehaviour
{
    public GameObject button;

    public static List<double> sortedList = new List<double>();
    public void Start()
    {
        string readFromFilePath = Application.dataPath + "/Resources/" + "data1" + ".txt";
        string readFromFilePath2 = Application.dataPath + "/Resources/" + "data2" + ".txt";

        List<string> list1 = File.ReadAllLines(readFromFilePath).ToList();
        List<string> list2 = File.ReadAllLines(readFromFilePath2).ToList();

        List<string> mergedList = new List<string>();
        mergedList = list1.Union<string>(list2).ToList<string>();

        try
        {
            sortedList = mergedList.Select(double.Parse).ToList();
            Debug.Log("Конвертация успешна");
        }
        catch
        {
            Debug.Log("ОШИБКА! В исходных файлах содержатся не только числа \n Измените содержание текстовых файлов");
            Application.Quit();
        }
        sortedList.Sort();
    }
}
