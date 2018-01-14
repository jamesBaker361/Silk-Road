using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCMEnu : MonoBehaviour {

	//these are prefabs
	public Merchant m;
	public MasterTalkCanvas mtc;

	//these aint prefabs; they gotta inputted in the gui tho
	public string babyMerchantName;

	//these get inherited
	public Sprite icon;
	public string name;

	//threse get initlized in start()
	public BabyMerchant bm;

	void Start () {
		if (bm == null) {
			bm = Babies.babyMerchantDict [babyMerchantName];
		}
		GetComponentInChildren<Exit> ().GetComponent<Button> ().onClick.AddListener (Exit);
		GetComponentInChildren<Trade> ().GetComponent<Button> ().onClick.AddListener (merchantMenu);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void merchantMenu(){
		Merchant mer=Instantiate(m);
		mer.eatBaby (bm);
	}

	public void Talk(){
		MasterTalkCanvas mast = Instantiate (mtc);
		mast.npcName = name;
		mast.npcSprite = icon;
	}

	public void Exit(){
		Debug.Log(">:):");
		Destroy (this.gameObject);
	}
}
