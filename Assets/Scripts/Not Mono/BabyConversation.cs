using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyConversation{
	public List<string> lines;
	public bool playerFirst; //this is whether the player is the first to speak or the NPC is
	public string title; //like the button to engage thsi conversation says the title like "discuss politics"

	public BabyConversation(List<string> l,bool player){
		lines = l;
		playerFirst = player;
	}

	public BabyConversation(List<string> l,bool player, string t){
		lines = l;
		playerFirst = player;
		title = t;
	}

	public BabyConversation(bool player){
		playerFirst = player;
		//lines.Add
	}
		
}
