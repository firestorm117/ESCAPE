using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleReactorStatus : MonoBehaviour,IInteractableObject,IConsoleUI
{
    // Start is called before the first frame update
   public bool active = false;
    bool status=false;
    public bool Status => status;

    public void action()
    {
        if (active)
        {
            status = true;
            gameObject.GetComponentInParent<ReactorStatusChecker>().check();
            gameObject.GetComponentInChildren<Text>().text = "Systems Active";
        }
    }

    public void updateUI()
    {
        gameObject.GetComponentInChildren<Text>().text = "REACTOR ACTIVE\nReroute Power";
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
