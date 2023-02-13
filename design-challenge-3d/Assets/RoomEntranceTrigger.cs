using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEntranceTrigger : MonoBehaviour
{
    public GameObject prototype_x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            prototype_x.gameObject.SetActive(true);
        }
    }
}
