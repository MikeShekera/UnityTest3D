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

    private const string divider = "---------------";
    private const float delayTime = 0.3f;

    public void LoadOnScreen()
    {
        FilesRead files = new FilesRead();
        files.Start();
        _sortedList = files.sortedList;

        if (_sortedList.Count == 0)
        {
            textObject.GetComponent<Text>().text = "Выводить нечего";
            Instantiate(textObject, contentWindow);
        }
        else
        {
            InvokeRepeating(nameof(Write), 0, delayTime);
        }
    }

    private void Write()
    {
        textObject.GetComponent<Text>().text = _sortedList[position].ToString();
        Instantiate(textObject, contentWindow);
        position++;

        if(position == _sortedList.Count)
        {
            textObject.GetComponent<Text>().text = divider;
            Instantiate(textObject, contentWindow);

            CancelInvoke();

            position = 0;
            textObject.GetComponent<Text>().text = "";
        }
    }
}
