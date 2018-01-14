using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

	public Collider2D col;
	public string scName;
	public Scene sce;
	void Start () {
		col = GetComponent<Collider2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		SceneManager.LoadScene (scName);
		SceneManager.SetActiveScene (SceneManager.GetSceneByName (scName));
	}

}
