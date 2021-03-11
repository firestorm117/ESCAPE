using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencePuzzle : MonoBehaviour
{
    int _current=0;
    [SerializeField]
    GameObject gb;
   public  void check(int id,GameObject gm)
    {
        if(_current==0 && id!=(_current+1))
        {
            activate(gm);
            _current = -1;
        }
        else if(_current+1==id)
        {
            activate(gm);
            _current++;
            if (_current == 5)
                complete();
        }
        else
        {
            deactivate();
        }
    }
    void activate(GameObject gm)
    {
        gm.GetComponent<SequenceConsole>().state = true; 
        gm.GetComponentInChildren<Image>().color = Color.green;

    }
    void deactivate()
    {
        _current = 0;
        SequenceConsole[] sq = gameObject.GetComponentsInChildren<SequenceConsole>();
        foreach(SequenceConsole s in sq)
        {
            s.state = false;
            s.gameObject.GetComponentInChildren<Image>().color = Color.red;
        }
    }
    void complete() 
    {

    }
}
