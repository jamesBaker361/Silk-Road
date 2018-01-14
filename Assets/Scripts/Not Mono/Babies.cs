using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Babies {
	public static BabyMerchant sixtynine = new BabyMerchant ("sixty nine", 69, 69, 69, 69, 69, 69);
	public static Dictionary<string,BabyMerchant> babyMerchantDict = new Dictionary<string,BabyMerchant>(){
		{ "sixtynine", sixtynine }
	};
	public static BabyConversation chatWithSofia=new BabyConversation(new List<string>(){
		"hey man",
		"hi sofia",
		"i like the >:) thong",
		"woah same"
	},false);
	public static Dictionary<string,BabyConversation> babyConvoDict=new Dictionary<string, BabyConversation>(){
		{"chatWithSofia",chatWithSofia}
	};
}
