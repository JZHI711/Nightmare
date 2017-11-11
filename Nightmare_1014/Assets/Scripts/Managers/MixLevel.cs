using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixLevel : MonoBehaviour {
    public AudioMixer masterMixer;
	// Use this for initialization
	public void SetfxLv1(float sfxLv1) {
        masterMixer.SetFloat("sfxVol", sfxLv1);
    }
    public void SetMusicLv1(float musicLv1)
    {
        masterMixer.SetFloat("sfxVol", musicLv1);
    }
}
