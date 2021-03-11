using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorConsole : MonoBehaviour, IInteractableObject
{

    [SerializeField]
    Renderer[] cells;
    bool activated = true;
    [SerializeField]
    GameObject console , ReacterEffect;

    public void action()
    {
        if(activated)
        {
            console.GetComponent<ConsoleReactorStatus>().active = true;
            console.GetComponent<IConsoleUI>().updateUI();
            foreach (Renderer ren in cells)
            {
                ren.material.SetColor("_EmissionColor", Color.green);
            }
            ReacterEffect.SetActive(true);
            changeText("Activated");
        }
    }
    void changeText(string txt)
    {
        gameObject.GetComponentInChildren<Text>().text = txt;
    }
}
