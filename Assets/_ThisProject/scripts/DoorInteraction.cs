using UnityEngine;
//Set it as a child of the door to which it is wired
public class DoorInteraction : MonoBehaviour, IInteractableObject
{
    // Start is called before the first frame update
    public bool activated = false;
    [SerializeField]
    bool requiresKeycard = false;
    [SerializeField]
    ObjectList key;
    GameObject ob;

    public void action()
    {
        if (requiresKeycard)
        {
            if (InventoryManager.im.isInInventory(key))
                activated = true;
        }
        if (activated)
        {
            doorAnimController script = gameObject.GetComponentInParent<doorAnimController>();

            if (script.DoorOpened)
            {
                script.closeDoor();
            }
            else
            {
                script.openDoor();
            }
            gameObject.GetComponent<IConsoleUI>()?.updateUI();
        }
    }
}
