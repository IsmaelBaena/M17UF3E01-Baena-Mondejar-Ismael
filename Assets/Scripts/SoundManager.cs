using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    private AudioSource audio;

    void Start() {
        audio = this.gameObject.GetComponent<AudioSource>();
    }
    
    public void playSucces()
    {
        audio.clip = Resources.Load<AudioClip>("succes");
        audio.Play();
    }

    public void playFailure()
    {
        audio.clip = Resources.Load<AudioClip>("failure");
        audio.Play();
    }
}
