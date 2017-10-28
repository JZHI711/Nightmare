using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
    private Canvas canvas;
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
        Time.timeScale = Time.timeScale == 0 ? 1:0 ;//暫停
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
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
