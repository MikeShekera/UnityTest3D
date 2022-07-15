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
        foreach (var x in _sortedList)
        {
            Debug.Log(x.ToString());
        }
        //InvokeRepeating("Write", 0, 0.3f);
    }

    private void Write()
    {
        Instantiate(textObject, contentWindow);
        textObject.GetComponent<Text>().text = _sortedList[position].ToString();
        position++;
        if(position == _sortedList.Count)
        {
            CancelInvoke();
            position = 0;
        }
    }
}
