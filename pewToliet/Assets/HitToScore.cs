using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HitToScore : MonoBehaviour {
	public string fileName = "weNeedToTalk.txt";

	public List<string> adj;
	public List<string> noun;
	string finalFilePath;

	// Use this for initialization
	void Start () {
		Debug.Log ("Path: " + Application.dataPath);
		finalFilePath = Application.dataPath + "/" + fileName;
		//adj = new List<string>();
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
			Debug.Log (adj.Count);
			noun.Add (rear);

			i++;
		}

		sr.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Target") {
			Debug.Log ("Hit");
			finalFilePath = Application.dataPath + "/" + fileName;
			StreamWriter sw = new StreamWriter(finalFilePath, true);
			int ran1 = Random.Range (0, 19);
			int ran2 = Random.Range (0, 19);
			if (ran1 < adj.Count && ran2 < noun.Count) {
				sw.WriteLine (adj [ran1] + " " + noun [ran2]);
				sw.Close();
			} else {
				Debug.Log ("out of range " + ran1 + " " + ran2);
			}
					
		}
	}
}
