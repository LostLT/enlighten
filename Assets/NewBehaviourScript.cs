using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}


	void OnCollisionEnter (Collision collision) {

			Debug.LogError (this.GetComponent<Collider>().name + " entered collision with " + GetComponent<Collider>().name);

	}

}

