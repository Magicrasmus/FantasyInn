using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{

    bool inVicinity = false;
    public Transform holdArea;
    // public Transform grabArea;
    private GameObject grabbedObject;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Beer")
        {
            inVicinity = true;
            grabbedObject = other.gameObject;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && inVicinity == true)
        {
            Debug.Log("Good Job");
            grabbedObject.transform.SetParent(player.transform);
            grabbedObject.transform.position = holdArea.position;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Beer")
        {
            
            inVicinity = false;
        }
    }
}
