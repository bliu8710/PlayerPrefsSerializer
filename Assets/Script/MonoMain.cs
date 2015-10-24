using UnityEngine;
using System.Collections;

public class MonoMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		UserData obj = new UserData("binlao");

		string objStr = SerializeUtils.Serialize<UserData>(obj);

		Debug.Log(objStr);

		UserData objNew = SerializeUtils.Deserialize<UserData>(objStr);

		Debug.Log(objNew.nameText + " name=" + objNew.GetName() + " intList=" + string.Join(",", objNew.intList.ToArray()) + " msg=" + objNew.chatMsg.msg);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
