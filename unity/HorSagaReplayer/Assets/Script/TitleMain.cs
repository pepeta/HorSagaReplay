using UnityEngine;
using System.Collections;

public class TitleMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log( "start" );
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel( "battle" );

		}
	}
}
