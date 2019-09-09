using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeProcess : MonoBehaviour
{
    public GameObject[] EndingPoints;
    private int indexEndingPoints = 0;
    private int label = 0;
    private float maxdifference = float.MinValue;
    private float step = 0;
    private bool stop = false;

    private float StartTime = 0;

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "FastProcess_blender_ext1")
        {
            gameObject.GetComponent<UnityEngine.UI.Text>().text = "";
        }
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
            return;

        if (SceneManager.GetActiveScene().name == "SlowProcess_blender_ext1")
        {
            float zdifference = Camera.main.transform.position.z - EndingPoints[indexEndingPoints].transform.position.z;
            zdifference = zdifference > 0 ? zdifference : zdifference * -1;
            if (zdifference > maxdifference && indexEndingPoints == 0)
            {
                maxdifference = zdifference;
                step = 30000 / maxdifference;
            }

            if (indexEndingPoints == 0)
                label = (int)(step * (maxdifference - zdifference));
            else
            {
                if ((EndingPoints.Length - 1) == indexEndingPoints && zdifference < 0.1)
                    label = label + Random.Range(0, 10);
                else
                    label = 30000 + (int)(step * (maxdifference - zdifference));
            }

            if (label > 29900 && indexEndingPoints == 0)
            {
                indexEndingPoints++;
                maxdifference = Camera.main.transform.position.z - EndingPoints[indexEndingPoints].transform.position.z;
                maxdifference = maxdifference > 0 ? maxdifference : maxdifference * -1;
                step = 10000 / maxdifference;
            }

            gameObject.GetComponent<UnityEngine.UI.Text>().text = label.ToString() + " years.";
        }

        if (SceneManager.GetActiveScene().name == "FastProcess_blender_ext1")
        {
            //if (Camera.main.GetComponent<SegmentsController>().Step > 1)
            //{
            // fino a 200 ms flusso arriva in fondo
            // da 200 ms fino a 1000 ms c'è il fission recycling
            // poi fino alla fine del filmato fino a 3000 ms. 
            float timeElapsed = Time.time - StartTime;
            if (timeElapsed < 25 && label < 200)
            {
                // fase 1
                step = 0.008f; // 200 / 25000 
                label = (int)(step * timeElapsed * 1000);
            }

            if (timeElapsed >= 25 && timeElapsed < 69 && label < 1000)
            {
                // fase 2 
                step = 0.02f; // 1 / (75-25);
                label = 200 + (int)(step * (timeElapsed - 25) * 1000);
            }

            if (timeElapsed >= 60 && label < 3000 && Camera.main.GetComponent<SegmentsController>().Step > 1)
            {
                // fase 3
                step = 0.012f;// 3 / 240;
                label = 1000 + (int)(step * (timeElapsed - 60) * 1000);
            }

            if (timeElapsed > 240)
            {
                label = label + Random.Range(0, 2);
            }

            gameObject.GetComponent<UnityEngine.UI.Text>().text = label.ToString() + " ms.";
            //}
        }
    }
}
