using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySell : MonoBehaviour {

	public Buy b;
	public Sell s;
	public string resource;
	public int price;
	public Inventory playerInv;
	// Use this for initialization
	void Start () {
		GetComponentInChildren<Price>().GetComponent<Text>().text="$"+price.ToString();
		GetComponentInChildren<Name> ().GetComponent<Text> ().text = resource;
		GetComponentInChildren<Buy> ().GetComponent<Button> ().onClick.AddListener (playerBuy);
		GetComponentInChildren<Sell> ().GetComponent<Button> ().onClick.AddListener (playerSell);
	}

	public void playerBuy(){
		//playerInv.money -= 1000;
		//GameObject.FindObjectOfType<Money> ().moreCash ();
//		Debug.Log (GetComponentInChildren<SpecialText> ().GetComponent<Text> ().text);
		int q = int.Parse (GetComponentInChildren<SpecialText> ().GetComponent<Text>().text);
		if (playerInv.money >= q * price && playerInv.goodsMax - playerInv.goodsQuantity >= q) {
			Debug.Log ("kachow");
			playerInv.changeQuantity (resource, q);
			playerInv.money -= q * price;
			GameObject.FindObjectOfType<Money> ().moreCash ();
		} else if (playerInv.money < q * price) {
			Debug.Log ("insufficient funds");
		} else {
			Debug.Log ("insufficient space");
		}
	}

	public void playerSell(){
		//playerInv.money += 1000;
	//	Debug.Log (GetComponentInChildren<SpecialText> ().GetComponent<Text> ().text);
		int q = int.Parse (GetComponentInChildren<SpecialText> ().GetComponent<Text>().text);
		if (playerInv.goods [resource] >= q) {
			playerInv.changeQuantity (resource, -1 * q);
			playerInv.money += q * price;
			GameObject.FindObjectOfType<Money> ().moreCash ();
		} else {
			//insufficient quantity
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
