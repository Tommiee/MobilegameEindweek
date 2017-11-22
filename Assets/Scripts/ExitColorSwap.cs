using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitColorSwap : MonoBehaviour {

    private Objectives _objectives;

	void Start () {
        //grabs the 'Objectives' script from the player
        _objectives = GameObject.Find("Player_Ball").GetComponent<Objectives>();
    }
	
	void Update () {
        //Changes colour
		if(_objectives._collectedAll == true)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
	}
}
