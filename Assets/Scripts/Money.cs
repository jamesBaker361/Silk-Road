using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {



	void Start () {
		GetComponent<Text> ().text = "$"+ GameObject.FindObjectOfType<Inventory> ().money.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moreCash(){
		Debug.Log ("money");
		string s = GameObject.FindObjectOfType<Inventory> ().newMoney(0).ToString();
		Debug.Log (GameObject.FindObjectOfType<Inventory> ().money);
		GetComponent<Text> ().text = "$"+ s.ToString();
		//GetComponent<Text> ()
	}
}
