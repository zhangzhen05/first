using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Dynamic : MonoBehaviour {
	public NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (new Rect (0, 0, 100, 50), "走下层")) {
			agent.areaMask = 9;
		}
		if (GUI.Button (new Rect (0, 100, 100, 50), "走上层")) {
			agent.areaMask = 17;
		}
	}
}
