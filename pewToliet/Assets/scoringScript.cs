using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class scoringScript : MonoBehaviour {

	public string fileName = "weNeedToTalk.txt";

	public List<string> adj;
	public List<string> noun;

	// Use this for initialization
	void Start () {
		Debug.Log ("Path: " + Application.dataPath);
		string finalFilePath = Application.dataPath + "/" + fileName;

		StreamReader sr = new StreamReader (finalFilePath);
		int i = 0;

		while (!sr.EndOfStream) {
			string line = sr.ReadLine ();
			string[] splitLine = line.Split (' ');
			string front = splitLine [0];
			string rear = splitLine [1];

			Debug.Log ("front: " + front);
			Debug.Log ("rear: " + rear);

			adj.Add (front);
			noun.Add (rear);

			i++;
		}

		sr.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
