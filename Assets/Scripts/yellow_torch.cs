﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class yellow_torch : MonoBehaviour {
	public Text hintText;
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((player.position - transform.position).magnitude < 10f)
		{
			hintText.text = "              The Knight is near by";
		}
		else {
			hintText.text = "";
		}
	
	}
}
