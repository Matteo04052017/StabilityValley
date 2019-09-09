using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Image black;
    public Animator anim;
    public float speed = 20f;
    private int indexNode = 0;
    private bool paused = false;
    private GameObject[] pois;
    private float guitime;
    private GameObject canvas;
    private GameObject[] poinode;
    
    // Use this for initialization
    void Start()
    {
        SplineController.OnPaused += SplineController_OnPaused;
        SplineController.OnMoving += SplineController_OnMoving;
        pois = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            pois[i] = GameObject.Find("PoI" + i);
            if (pois[i] != null)
                pois[i].SetActive(false);
        }

        canvas = GameObject.Find("Canvas");
        if (canvas != null)
            canvas.SetActive(false);
        guitime = float.MinValue;
        poinode = GameObject.FindGameObjectsWithTag("PoINode");
    }

    private void SplineController_OnMoving()
    {
        if (paused)
        {
            paused = false;
            Debug.Log("moving " + indexNode);
            if (indexNode >= pois.Length)
                return;

            pois[indexNode /*- 1*/].SetActive(false);
            indexNode++;
        }
    }

    private void SplineController_OnPaused()
    {
        if (!paused)
        {
            paused = true;
            Debug.Log("paused " + indexNode);
            if (indexNode >= pois.Length)
                return;

            //bool show = false;
            //foreach (var item in poinode)
            //{
            //    if ((item.transform.position - gameObject.transform.position) == Vector3.zero)
            //        show = true;
            //}
            //if (show)
            //{
            pois[indexNode].SetActive(true);
            //    indexNode++;
            //}
        }
    }


    //void OnGUI()
    //{
    //    if (!_OnGUI)
    //        return;


    //GUI.Box(new Rect(10, 10, 100, 90), "Help");
    //GUI.Label(new Rect(20, 40, 50, 50), "RightArrow: move camera to the right");
    //GUI.Label(new Rect(20, 40, 50, 50), "LeftArrow: move camera to the left");
    //GUI.Label(new Rect(20, 40, 50, 50), "UpArrow: move camera up");
    //GUI.Label(new Rect(20, 40, 50, 50), "DownArrow: move camera down");
    //GUI.Label(new Rect(20, 40, 50, 50), "F: move camera forward");
    //GUI.Label(new Rect(20, 40, 50, 50), "B: move camera backward");
    //GUI.Label(new Rect(20, 40, 50, 50), "E/Q: rotate camera on X axis");
    //GUI.Label(new Rect(20, 40, 50, 50), "A/D: rotate camera on Y axis");
    //GUI.Label(new Rect(20, 40, 50, 50), "Q/E: rotate camera on Z axis");
    //GUI.Label(new Rect(20, 40, 50, 50), "P: show/hide points of interest");
    //GUI.Label(new Rect(20, 40, 50, 50), "1: switch to the Slow Process");
    //GUI.Label(new Rect(20, 40, 50, 50), "2: switch to the Fast Process");
    //GUI.Label(new Rect(20, 40, 50, 50), "I: show this help");
    //}

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.B))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.P) && (Time.time - guitime) > 1)
        {
            guitime = Time.time;
            for (int i = 0; i < 4; i++)
            {
                pois[i].SetActive(!pois[i].activeSelf);
            }
        }
        if (Input.GetKey(KeyCode.I) && (Time.time - guitime) > 1)
        {
            guitime = Time.time;
            canvas.SetActive(!canvas.activeSelf);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            StartCoroutine(Fading_SlowProcess_blender_ext1());
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            StartCoroutine(Fading_FastProcess_blender_ext1());
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    IEnumerator Fading_SlowProcess_blender_ext1()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene("SlowProcess_blender_ext1");
    }

    IEnumerator Fading_FastProcess_blender_ext1()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene("FastProcess_blender_ext1");
    }
}
