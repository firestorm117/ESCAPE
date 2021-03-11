using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour, IInteractableObject
{
    [SerializeField]
    ObjectList id;

    public void action()
    {
        InventoryManager.im.add(id);
        Destroy(gameObject);
    }

}
