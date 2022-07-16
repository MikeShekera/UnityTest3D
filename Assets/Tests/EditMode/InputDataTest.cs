using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;

public class InputDataTest 
{
    [Test]
    public void MergeTest()
    {
        FilesRead files = new FilesRead();
        files.FilesProcessing();

        List<double> _sortedList = files.sortedList;
        IEnumerable<string> _list1 = files.list1;
        IEnumerable<string> _list2 = files.list2;
        Assert.IsTrue(_sortedList.Count <= _list1.Count() + _list2.Count());
    }
}
