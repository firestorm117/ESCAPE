using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour,IInteractableObject
{
    [SerializeField]
    bool containsitem=false;
    public void action()
    {
        doorAnimController script = gameObject.GetComponent<doorAnimController>();
        
        if (script.DoorOpened)
        {
            script.closeDoor();
        }
        else
        {
            script.openDoor();
            if (containsitem)
            {
                gameObject.GetComponent<Collider>().enabled = false;
            }
        }
        
       // gameObject.GetComponent<Collider>().enabled = false;
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
