using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenOutput : MonoBehaviour
{
    public Transform contentWindow;

    public GameObject textObject;
    public void LoadOnScreen()
    {
        List<double> _sortedList = FilesRead.sortedList;

        foreach (var x in _sortedList)
        {
            Instantiate(textObject, contentWindow);
            textObject.GetComponent<Text>().text = x.ToString();
        }
    }
}
