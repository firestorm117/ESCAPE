using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class ObjectSelector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform start;
    [SerializeField]
    float rayDistance=2.5f;

    GameObject _current;
    void Start()
    {
        GameObject[] gg = GameObject.FindGameObjectsWithTag("Object");
        foreach(GameObject g in gg)
        {
            _current = g;
            changeOutline(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_current !=null)
        {
            changeOutline(false);
        }
        if(Physics.Raycast(start.position,start.forward,out RaycastHit hit,rayDistance))
        {
            GameObject ob = hit.transform.gameObject;
           // Debug.Log(ob);
            if( ob.CompareTag("Object"))
            {
                _current = ob;
                changeOutline(true);
                if (Input.GetMouseButtonDown(0))
                {
                    ob.GetComponent<IInteractableObject>().action();
                }
            }
        }
    }
    void changeOutline(bool value)
    {
        if (_current.GetComponent<Outline>() != null)
             _current.GetComponent<Outline>().enabled = value;
        Outline[] ch = _current.GetComponentsInChildren<Outline>();
        foreach (Outline o in ch)
        {
            o.enabled = value;
        }
    }
}
