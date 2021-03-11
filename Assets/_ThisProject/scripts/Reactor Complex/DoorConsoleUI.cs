using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorConsoleUI : MonoBehaviour,IConsoleUI
{
  bool state = false;
    public void updateUI()
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

    }

}
