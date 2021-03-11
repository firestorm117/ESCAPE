using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleActivator : MonoBehaviour
{
    [SerializeField]
    GameObject wiredConsole;
    bool _activated = false;
    [SerializeField]
    GameObject powerCell;
    public void check()
    {
        ConsoleStateChanger[] scripts = gameObject.GetComponentsInChildren<ConsoleStateChanger>();
        foreach(ConsoleStateChanger csc in scripts)
        {
            if (csc.state == false)
            {
                if(_activated)
                {
                    deactivateConsole();
                }
                return;
            }
        }
        activateConsole();
    }
    void activateConsole()
    {
        _activated = true;
        powerCell.GetComponent<Renderer>().material.SetColor("_EmissionColor",Color.red);
        wiredConsole.GetComponent<DoorInteraction>().activated = true;
        wiredConsole.GetComponentInChildren<Text>().text = "POWER ON";
    }
    void deactivateConsole()
    {
        _activated = false;
        wiredConsole.GetComponent<DoorInteraction>().activated = false;
        wiredConsole.GetComponentInChildren<Text>().text = "POWER\nDOWN";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
