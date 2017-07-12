using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointLabel : MonoBehaviour {
	
	public Text content;
	Object TextObject;
	// Use this for initialization
	void Start () {
		 TextObject = GameObject.Find ("CoinBehavior");
	}
	
	// Update is called once per frame
	void Update () {
		content.text = TextObject.Update();
	}
}
