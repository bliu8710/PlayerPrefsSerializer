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

	public Dictionary<int, List<ChatMsgDataItem>> chatMsgMap;

	public UserData(string name)
	{
		_name = name;
		nameText = "name_" + name;

		intList = new List<string> { "9", "10", "11" };

		chatMsg = new ChatMsgDataItem
		{
			msg = "myMsg",
			msg2 = "myMsg2"
		};

		chatMsgMap = new Dictionary<int, List<ChatMsgDataItem>>();
		chatMsgMap.Add(1024, new List<ChatMsgDataItem> { chatMsg });
	}

	public string GetName()
	{
		return _name;
	}
}
