using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    Color color;
    float timer = 0f;
    float interval = 10f;

    // Start is called before the first frame update
    void Start()
    {
        color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
            gameObject.GetComponent<Renderer>().material.color = color;
            timer = 0;
        }
    }
}
