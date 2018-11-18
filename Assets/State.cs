using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

	[SerializeField]
	[TextArea(14, 10)]
	string storyText; 

	[SerializeField]
	State[] nextStates; 

	public string StateStory { 
		get {
			return storyText;
		} 
	}

	public State[] NextStates { get {
		return nextStates;
	} }

}
