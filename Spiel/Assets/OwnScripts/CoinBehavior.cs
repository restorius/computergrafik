using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class CoinBehavior : MonoBehaviour {
	int value = 100;
	public int points=0;
	public Text content;
	public CoinBehavior coin;


	// Use this for initialization
	void Start () {
		coin = gameObject.GetComponent<CoinBehavior>();	
		content.text = "Punkte: ";

	}
	
	// Update is called once per frame
	void Update () {
		this.content.text = points.ToString();
	}

	void OnTriggerEnter ( )
	{
		GameObject.Destroy ( gameObject ) ;
		points += value;


	}
}
