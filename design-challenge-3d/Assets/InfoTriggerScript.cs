using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTriggerScript : MonoBehaviour
{
    public GameObject lights;
    List<Renderer> renderers = new List<Renderer>();
    bool pchecker = false; //is to check if the player is still inside the zone 
    float timer = 0f; //timer to count how many seconds the user stays inside the zone

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pchecker)
            timer += Time.deltaTime; //is to count how many seconds player is inside
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //checks if the collider is the player
        {
            pchecker = true; //says that the player is inside the area

            if (lights != null)
                foreach (Renderer r in lights.GetComponentsInChildren<Renderer>())
                    r.material.color = Color.green;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //checks again if the player leaves
        {
            pchecker = false; //tells Update that the player left
            Debug.Log("Player spent " + timer + "s looking at the screen!"); //prints the timer
            timer = 0; //resets timer
        }
    }
}
