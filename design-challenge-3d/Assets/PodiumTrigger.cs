using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodiumTrigger : MonoBehaviour
{
    bool pchecker = false; //used to check if player is still inside
    public GameObject myPrefab; //the object you want instantiate
    GameObject clone; //this is the NEW prototype we instatiate
    Vector3 loc = new Vector3(-3.454f, 1.305923f, 3.541f); //where the prototype will be instantiated

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pchecker)
            if (Input.GetKeyDown(KeyCode.E))
                {
                    clone.transform.GetChild(0).GetComponent<Rigidbody>().useGravity = true;
                    clone.transform.GetChild(0).GetComponent<Rigidbody>().AddForce(100*Vector3.forward);
                    Destroy(clone.GetComponent<Showcase>());
                    clone = null;
                }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pchecker = true;
            if (clone == null)
                clone = Instantiate(myPrefab, loc, Quaternion.identity);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pchecker = false;
        }
    }
}
