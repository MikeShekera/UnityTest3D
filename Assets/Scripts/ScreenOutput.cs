using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ScreenOutput : MonoBehaviour
{
    public Transform contentWindow;

    public GameObject textObject;

    private int position = 0;

    private List<double> _sortedList;
    public void LoadOnScreen()
    {
        _sortedList = FilesRead.sortedList;

        InvokeRepeating("Write", 0, 0.3f);
    }

    private void Write()
    {
        textObject.GetComponent<Text>().text = _sortedList[position].ToString();
        Instantiate(textObject, contentWindow);
        position++;
        if(position == _sortedList.Count)
        {
            CancelInvoke();
            position = 0;
            textObject.GetComponent<Text>().text = "";
        }
    }
}
