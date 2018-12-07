using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    Text textComponent;

    [SerializeField]
    State startingState;

    State currentState;

    // Use this for initialization
    void Start()
    {
        currentState = startingState;
        textComponent.text = currentState.StateStory;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    public void ManageState()
    {
        var nextStates = currentState.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = nextStates[0];
        }
        
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = nextStates[1];
        }
        
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentState = nextStates[2];
        }
    }
}
