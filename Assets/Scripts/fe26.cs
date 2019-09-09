using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fe26 : MonoBehaviour
{
    private float startTime;

    public float startAfterSS = 3;
    public float stopAfterSS = 10;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > startAfterSS)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        if (Time.time - startTime > stopAfterSS)
        {
            gameObject.SetActive(false);
        }
    }
}
