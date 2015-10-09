using UnityEngine;
using System.Collections;

public class guipuke : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUI.TextArea(new Rect(10,10,100,100), "This better not say nuthing about Marcus");

    }
}
