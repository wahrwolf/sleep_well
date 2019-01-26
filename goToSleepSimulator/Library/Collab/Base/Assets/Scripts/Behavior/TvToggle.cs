using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvToggle : MonoBehaviour, ToDoInterface
   
{
    GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        Transform tempPlane = this.transform.Find("Screensaver");
        if(tempPlane!=null)
        {
            this.plane = tempPlane.gameObject;
        } else
        {
            Debug.Log("Could not load TV Plane!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool taskDone()
    {
        return !this.plane.activeSelf;
    }

    private void OnTriggerEnter(Collider other)
    {
        this.plane.SetActive(false);
        Debug.Log("TV Hit");
    }
}
