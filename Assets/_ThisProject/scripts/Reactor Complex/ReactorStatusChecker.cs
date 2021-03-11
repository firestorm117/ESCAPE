using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactorStatusChecker : MonoBehaviour
{
    [SerializeField]
    GameObject central;
    [SerializeField]
    ReflectionProbe rp;
    Text txtbox;
    // Start is called before the first frame update
    void Start()
    {
        txtbox = gameObject.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void check()
    {
        ConsoleReactorStatus[] reactors = gameObject.GetComponentsInChildren<ConsoleReactorStatus>();
        foreach(ConsoleReactorStatus cr in reactors)
        {
            if (!cr.Status)
            {
                return;
            }
        }
        changeColor(Color.green);
        StartCoroutine(changeText(0, "Initiating..."));
        StartCoroutine(changeText(2.5f, "ALL SYSTEMS\nWORKING"));
        Invoke(nameof(reactorOnSequence),2);
        Invoke(nameof(reactorOffSequence),2.1f);
        Invoke(nameof(reactorOnSequence), 2.2f);
        Invoke(nameof(reactorOffSequence), 2.3f);
        Invoke(nameof(reactorOnSequence), 2.4f);
    }
    void reactorOnSequence()
    {
        central.SetActive(true);
        rp.RenderProbe();
    }
    void reactorOffSequence()
    {
        central.SetActive(false);
        rp.RenderProbe();
    }
    IEnumerator changeText(float delay, string txt)
    {
        yield return new WaitForSeconds(delay);
        txtbox.text = txt;
    }
    void changeColor(Color c)
    {
        txtbox.color = c;
    }
}
