using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HCI_Trigger : MonoBehaviour
{
    public GameObject lights;

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
        if (other.gameObject.CompareTag("Player") && lights.GetComponent<Renderer>().material.color == Color.green)
        {
            SceneManager.LoadScene("HCI_LAB_ROOM");
        }
    }
}
