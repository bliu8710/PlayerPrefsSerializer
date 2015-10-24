using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class UserData
{
	private string _name;
	public string nameText;
	public List<string> intList;

	public ChatMsgDataItem chatMsg;

	public UserData(string name)
	{
		_name = name;
		nameText = "name_" + name;

		intList = new List<string> { "9", "10", "11" };

		chatMsg = new ChatMsgDataItem
		{
			msg = "myMsg"
		};
	}

	public string GetName()
	{
		return _name;
	}
}
