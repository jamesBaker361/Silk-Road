using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour {
	//prefabs
	public NPCMEnu np;

	//initialized in gui
	public string name;
	public Sprite icon;
	public string babyMerchantName;
	public List<string> convoList; //so this will be a list of convos that the NPC can do 
	//temporarily for testing were just gonna have it be a single string
	public string convo


	//intializd in start()
	public BabyMerchant bm;

	void Start () {
		//bm = Babies.sixtynine;
		convoList=new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		NPCMEnu menu = Instantiate (np);
		menu.babyMerchantName = babyMerchantName;
		menu.name = name;
		menu.icon = icon;
		if (bm != null) {
			menu.bm = bm;
		}
	}
}
