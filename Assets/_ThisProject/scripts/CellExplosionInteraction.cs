using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellExplosionInteraction : MonoBehaviour,IInteractableObject
{
    [SerializeField]
    GameObject explosionPrefab;
    public void action()
    {
        explosionPrefab.transform.SetParent(null);
        Invoke(nameof(explode), 3);
    }
    void explode()
    {
        explosionPrefab.SetActive(true);
        Destroy(gameObject);
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
