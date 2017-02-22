using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelLoader : MonoBehaviour {
	public string stageFileName;
	// Use this for initialization
	void Start () {
		string filePath = Application.dataPath + "/" + stageFileName;
		StreamReader sr = new StreamReader (filePath);
		GameObject levelHolder = new GameObject ("Level Holder");
		int yPos = 0;

		while (!sr.EndOfStream) {
			string line = sr.ReadLine ();

			for (int xPos = 0; xPos < line.Length; xPos++) {
				if (line [xPos] == 'x') {
					GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
					cube.transform.parent = levelHolder.transform;
					cube.transform.position = new Vector3 (xPos, yPos, 0);
				}
			}

			yPos--;
		}



		sr.Close ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
