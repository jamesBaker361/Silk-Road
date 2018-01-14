using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	public string scName;
	// Use this for initialization
	void Start () {
		//SceneManager.LoadSceneAsync (scName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayTime(){
		for (int z = 0; z < SceneManager.sceneCountInBuildSettings; z++) {
			//Debug.Log (SceneManager.GetSceneAt (z));
		}
		SceneManager.LoadScene (scName);
		SceneManager.SetActiveScene (SceneManager.GetSceneByName (scName));
	}
}
