using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceConsole : MonoBehaviour, IInteractableObject
{
    [SerializeField]
    int id;
    bool _state = false;
    public bool state
    {
        get { return _state; }
        set { _state = value; }
    }

    public void action()
    {
        if(!_state)
            gameObject.GetComponentInParent<SequencePuzzle>().check(id,gameObject);
    }
}
    
