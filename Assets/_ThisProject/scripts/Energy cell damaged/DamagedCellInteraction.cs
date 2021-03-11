using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedCellInteraction : MonoBehaviour, IInteractableObject
{
    [SerializeField]
    GameObject cell;
    [SerializeField]
    Renderer newcell;
    bool damaged = true;
    public void action()
    {
        if(damaged)
        {
            cell.SetActive(false);
            damaged = false;
            return;
        }
        if(InventoryManager.im.isInInventory(ObjectList.ActiveCell))
        {
            cell.SetActive(true);
            newcell.material.SetColor("_EmissionColor", Color.green);
            gameObject.tag = "Untagged";
        }
    }
}
