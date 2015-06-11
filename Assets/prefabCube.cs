using UnityEngine;
using System.Collections;

public class prefabCube : MonoBehaviour {

	public GameObject cubePrefabVar;

	// Use this for initialization
	void Start () {
		//Instantiate (cubePrefabVar);
	}
	
	// Update is called once per frame
	void Update () {
		Instantiate (cubePrefabVar);

	}
}
