using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Merchant : MonoBehaviour {

	public int MartinisPrice;
	public int RecordsPrice;
	public int SodaPrice;
	public int HooversPrice;
	public int PhonesPrice;
	public int JewelryPrice;

	public BuySell biseal;

	public Inventory playerInv;

	//public Sprite background;
	//public GameObject img;

	public Dictionary<string, int> goods;
	// Use this for initialization
	void Start () {
		GetComponentInChildren<Exit> ().GetComponent<Button> ().onClick.AddListener (Exit);
		playerInv = GameObject.FindObjectOfType<Inventory> ();
		//transform = GetComponentInParent<Transform> ();
		goods = new Dictionary<string, int> () {
			{ "Martinis",MartinisPrice },
			{ "Records",RecordsPrice },
			{ "Soda Pop",SodaPrice },
			{ "Hoovers",HooversPrice },
			{ "Phones",PhonesPrice },
			{ "Jewelry",JewelryPrice }
		};
		/*for (int y = 0; y < goods.Count; y++) {
			BuySell newBS = Instantiate (biseal);
			newBS.GetComponent<RectTransform>().position.x=-100 + (50 * y);
			//newBS.transform.position.x = -100 + (50 * y);
			newBS.resource = goods.Keys.ElementAt(y);
		}*/
		int y = 0;
		int marginHorz = (int)((GetComponent<RectTransform> ().rect.width/2f)-100f);
		int marginVert=(int)((GetComponent<RectTransform> ().rect.height/2f)-50f);
		foreach (KeyValuePair<string,int> item in goods) {
			BuySell newBS = Instantiate (biseal, 
				new Vector3 (marginHorz+(100*(y%3)),
					marginVert+(100*(y%2)), 0),
				transform.rotation,
				GetComponentInParent<Transform> ());
			newBS.resource = item.Key;
			newBS.price = item.Value;
			newBS.playerInv = this.playerInv;
			//newBS.GetComponentInChildren<Buy> ().GetComponent<Button> ().onClick.AddListener (playerBuy);
			y++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Exit(){
		Debug.Log(">:):");
		Destroy (this.gameObject);
	}

	public void eatBaby(BabyMerchant bm){
		MartinisPrice = bm.MartinisPrice;
		RecordsPrice = bm.RecordsPrice;
		PhonesPrice = bm.PhonesPrice;
		SodaPrice = bm.SodaPrice;
		JewelryPrice = bm.JewelryPrice;
		HooversPrice = bm.HooversPrice;
	}

}
