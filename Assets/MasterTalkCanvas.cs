using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterTalkCanvas : MonoBehaviour {

	//prefabs
	public TalkCanvas player;
	public TalkCanvas npc;

	public string convo;
	public BabyConversation bm;

	//initialized in start()
	public TalkCanvas current;
	public bool playersTurn;
	public string playersName;
	public Sprite playerSprite;
	public int c=0;

	//initliazed by an outside element
	public string npcName;
	public Sprite npcSprite;

	// Use this for initialization
	void Start () {
		if (bm == null) {
			bm = Babies.babyConvoDict [convo];
		}
		playersTurn = !bm.playerFirst;
		if (bm.playerFirst) {
			makePlayer ();
		} else {
			makeNPC ();
		}
		current.GetComponentInChildren<Name> ().GetComponent<Text> ().text = bm.lines [c];
	}

	public void makeNPC(){
		current = Instantiate (npc);
		current.GetComponentInChildren<Icon> ().GetComponent<Image> ().sprite = npcSprite;
		current.GetComponentInChildren<Name> ().GetComponent<Text> ().text = npcName;
	}

	public void makePlayer(){
		current = Instantiate (player);
		current.GetComponentInChildren<Icon> ().GetComponent<Image> ().sprite = playerSprite;
		current.GetComponentInChildren<Name> ().GetComponent<Text> ().text = playersName;
	}

	public void nextLine(){
		c++;
		if (c >= bm.lines.Count) {
			Destroy (this);
		}
		if (playersTurn) {
			Destroy (current);
			makePlayer ();
		} else {
			Destroy (current);
			makeNPC ();
		}
		current.GetComponentInChildren<Name> ().GetComponent<Text> ().text = bm.lines [c];
		playersTurn = !playersTurn;
	}


	
	// Update is called once per frame
	void Update () {
		
	}

	public void eatBaby(BabyConversation b){
		bm = b;
	}
}
