using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ConsoleStateChanger : MonoBehaviour,IInteractableObject
{
    // Start is called before the first frame update
    public bool state = false;
    public void action()
    {
        if (state)
        {
            state = false;
            gameObject.GetComponentInChildren<Image>().color = Color.red;
        }
        else
        {
            state = true;
            gameObject.GetComponentInChildren<Image>().color = Color.green;
        }
        gameObject.GetComponentInParent<ConsoleActivator>().check();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
