using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorAnimController : MonoBehaviour
{
    [SerializeField]
    bool door_opened = false;
    Animator _anim;
    public  bool DoorOpened =>door_opened;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        if (door_opened)
            _anim.SetTrigger("openDoor");
    }
    public void openDoor()
    {
        if(!door_opened)
        {
            _anim.SetTrigger("openDoor");
            door_opened = true;
        }
    }
    public void closeDoor()
    {
        if (door_opened)
        {
            _anim.SetTrigger("closeDoor");
            door_opened = false;
        }
    }
}
