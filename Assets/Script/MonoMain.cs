using UnityEngine;
using System.Collections;

public class MonoMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Save()
	{
		UserData obj = new UserData("binlao");

		string objStr = SerializeUtils.Serialize<UserData>(obj);

		Debug.Log("Save= " + objStr);

		PlayerPrefs.SetString("UserData", objStr);
	}

	public void Load()
	{
		//
		string dataStr = PlayerPrefs.GetString("UserData");
		Debug.Log("Load= " + dataStr);

		//
		UserData objNew = SerializeUtils.Deserialize<UserData>(dataStr);
		Debug.Log(objNew.nameText
			+ " name=" + objNew.GetName()
			+ " intList=" + string.Join(",", objNew.intList.ToArray())
			+ " msg=" + objNew.chatMsg.msg
			+ " msg2=" + objNew.chatMsg.msg2
			+ " 1024Msg=" + objNew.chatMsgMap[1024][0].msg
		);
	}
}
