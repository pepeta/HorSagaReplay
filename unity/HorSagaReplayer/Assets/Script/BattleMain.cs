using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using System;


public class BattleMain : MonoBehaviour {

	private string guitxt = "";

	// Use this for initialization
	void Start () {

		//	データ読み込み
		_readFile ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//	データ読み込
	void _readFile()
	{
		// FileReadTest.txtファイルを読み込む
		FileInfo fi = new FileInfo(Application.dataPath + "/" + "data.csv");
		try {
			// 一行毎読み込み
			using (StreamReader sr = new StreamReader(fi.OpenRead(), Encoding.UTF8)){
				guitxt = sr.ReadToEnd();
			}
		} catch (Exception /* e */ ){
			// 改行コード
			guitxt += SetDefaultText();
		}
	}

	//	改行コード処理
	string SetDefaultText(){
		return "C#あ\n";
	}

}
