using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {
	void Update(){
		if(Input.GetMouseButton(0))
		{
			Application.LoadLevel("_Scene_0");
		}
	}
}