using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InputDataTest
{
	[Test]
	public void MergeTest()
	{
		string readFromFilePath = Application.dataPath + "/Resources/" + "data1" + ".txt";
		string readFromFilePath2 = Application.dataPath + "/Resources/" + "data2" + ".txt";

		List<string> list1 = File.ReadAllLines(readFromFilePath).ToList();
		List<string> list2 = File.ReadAllLines(readFromFilePath2).ToList();

		List<string> mergedList = new List<string>();
		mergedList = list1.Union<string>(list2).ToList<string>();

		Assert.IsTrue(mergedList.Count <= list2.Count+list1.Count);
	}
}
