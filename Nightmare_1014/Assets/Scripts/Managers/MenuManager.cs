using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour {
    private Canvas canvas;
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unPaused;
	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.enabled = !canvas.enabled;//開關canvas
            Pause();
        }
	}
    public void Pause() {
        Time.timeScale = Time.timeScale == 0 ? 1:0 ;
        LowPass();
        //暫停
        /*等同於
        if(Time.timeScale==0)
        {
            Time.timeScale=1;
        }
        else
        {
            Time.timeScale=0;
        }*/

           }
    private void LowPass() {    //切換時間
        if (Time.timeScale == 0)
        {
            paused.TransitionTo(0.01f);
        }
        else
        {
            unPaused.TransitionTo(0.01f);
        }
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
