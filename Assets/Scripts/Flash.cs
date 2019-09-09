using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public float flashingTime = .5f;
    public float delay = 40;
    private float lastTime = float.MinValue;
    private float startTime;
    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time < (startTime + delay))
            return;

        if (Camera.main.GetComponent<SegmentsController>().Step > 1)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            return;
        }
        
        if (Time.time - lastTime > flashingTime)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<MeshRenderer>().enabled;
            lastTime = Time.time;
        }
    }
}
