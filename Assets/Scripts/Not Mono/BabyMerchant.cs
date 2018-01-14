using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMerchant {

	public string name;
	public int MartinisPrice;
	public int RecordsPrice;
	public int SodaPrice;
	public int HooversPrice;
	public int PhonesPrice;
	public int JewelryPrice;

	public BabyMerchant(string n, int mar, int rec, int sod, int hoo, int pho, int jew){
		name = n;
		MartinisPrice = mar;
		RecordsPrice = rec;
		SodaPrice = sod;
		HooversPrice = hoo;
		PhonesPrice = pho;
		JewelryPrice = jew;
	}

}
