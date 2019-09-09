using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ChangeIntroScene : MonoBehaviour {
    private VideoPlayer videoPlayer;
    private bool coroutineStarted = false;
    public Image black;
    public Animator anim;

	// Use this for initialization
	void Start () {
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!videoPlayer.isPrepared || videoPlayer.isPlaying)
            return;

        if (!coroutineStarted)
        {
            StartCoroutine(Fading());
            coroutineStarted = true;
        }
	}

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene("SlowProcess_blender_ext1");
    }
}
