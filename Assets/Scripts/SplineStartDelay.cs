using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineStartDelay : MonoBehaviour
{
    private float startTime;
    public float delayTime = 10;
    // Use this for initialization
    void Start()
    {
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > delayTime)
        {
            gameObject.GetComponent<SplineController>().go = true;
        }
    }
}
