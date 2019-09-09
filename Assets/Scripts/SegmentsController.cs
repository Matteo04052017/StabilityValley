using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentsController : MonoBehaviour
{
    private int step = 0;
    private float startTime = float.MinValue;
    public float step1Time = 50;
    public float step2Time = 70;

    public int Step
    {
        get
        {
            return step;
        }
    }

    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Step >= 2)
            return;

        if (Time.time - startTime > step1Time)
        {
            if (Step == 0)
            {
                int i = 1;
                GameObject[] objs = GameObject.FindGameObjectsWithTag("step" + Step);
                foreach (var item in objs)
                {
                    ParticleSystem ps = item.GetComponent<ParticleSystem>();
                    if (ps != null)
                    {
                        var main = ps.main;
                        main.startLifetime = 10f;
                        ps.Stop();
                    }
                    else
                        Destroy(item, i++);
                }
                step++;
                return;
            }

            if (Time.time - startTime > step2Time)
            {
                GameObject[] objs = GameObject.FindGameObjectsWithTag("step" + Step);
                foreach (var item in objs)
                {
                    ParticleSystem ps = item.GetComponent<ParticleSystem>();
                    ps.Play();
                }
                step++;
            }
        }
    }
}
