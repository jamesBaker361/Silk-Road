using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	// Use this for initialization
	public List<Item> items;
	public int itemMax=10;

	public int money=10000;

	public int goodsQuantity=0;
	public int goodsMax=100;
	public Sprite spr;
	public string name;

	public Dictionary<string, int> goods;

	void Start () {
		DontDestroyOnLoad (this);
		goods = new Dictionary<string, int> (){
			{"Martinis",0},
			{"Records",0},
			{"Hoovers",0},
			{"Soda Pop",0},
			{"Jewelry",0},
			{"Phones",0}
		};
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeQuantity(string good, int quant){
		goods [good] += quant;
	}

	public int newMoney(int change){
		money += change;
		return(money);
	}

	public int newQuantity(int change){
		goodsQuantity += change;
		return(goodsQuantity);
	}
		
	/*
	public void addMartinis(int q){
		int add=Mathf.Min(goodsMax-goodsQuantity,q);
		Martinis += add;
		goodsQuantity += add;
	}

	public void addRecords(int q){
		int add=Mathf.Min(goodsMax-goodsQuantity,q);
		Records += add;
		goodsQuantity += add;
	}

	public void addTypewriters(int q){
		int add=Mathf.Min(goodsMax-goodsQuantity,q);
		Typewriters += add;
		goodsQuantity += add;
	}

	public void addHoovers(int q){
		int add=Mathf.Min(goodsMax-goodsQuantity,q);
		Hoovers += add;
		goodsQuantity += add;
	}

	public void addSoda(int q){
		int add=Mathf.Min(goodsMax-goodsQuantity,q);
		Soda += add;
		goodsQuantity += add;
	}

	public void addJewelry(int q){
		int add=Mathf.Min(goodsMax-goodsQuantity,q);
		Jewelry += add;
		goodsQuantity += add;
	} */

	public void addItem(Item i){
		if (items.Count < itemMax) {
			items.Add (i);
		} else {
			//ruh roh!
		}
	}
}
