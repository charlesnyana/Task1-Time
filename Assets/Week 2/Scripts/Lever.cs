using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (door.activeInHierarchy==true) {
            Debug.Log("Door is open.");
            door.SetActive(false);
        } else {
            Debug.Log("Door is closed.");
            door.SetActive(true);
        }
    }
}
