using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceScript : MonoBehaviour
{
    public Transform toLookAt;
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
            other.transform.LookAt(new Vector3(toLookAt.position.x, transform.position.y, toLookAt.position.z));
            Camera.main.transform.LookAt(toLookAt);
        }
    }
}
