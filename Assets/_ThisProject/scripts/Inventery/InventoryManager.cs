using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    List<ObjectList> inventory = new List<ObjectList>();
    public static InventoryManager im;
    private void Awake()
    {
        im = this.GetComponent<InventoryManager>();
    }
    public void add(ObjectList ob)
    {
        inventory.Add(ob);
    }
    public void remove(ObjectList ob)
    {
        inventory.Remove(ob);
    }
    public bool isInInventory(ObjectList ob)
    {
        return inventory.Contains(ob);
    }

}
