using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializeUtils
{
	public static string Serialize<T> (T obj)
	{
		var b = new BinaryFormatter();

		var m = new MemoryStream();

		b.Serialize(m, obj);

		string outputStr = Convert.ToBase64String(m.ToArray());
		
		m.Close();

		return outputStr;
	}

	public static T Deserialize<T> (string str)
	{
		var b = new BinaryFormatter();

		var m = new MemoryStream(Convert.FromBase64String(str));

		T obj = (T)b.Deserialize(m);

		m.Close();

		return obj;
	}
}
