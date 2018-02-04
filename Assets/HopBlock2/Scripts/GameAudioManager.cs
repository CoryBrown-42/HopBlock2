using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class GameAudioManager : MonoBehaviour {

    public AudioClip MainJingle;

    public AudioClip hover;

    public AudioSource UInoiseMaker;

    AudioSource gmaSource;

	// Use this for initialization
	void Start () {
        gmaSource = GetComponent<AudioSource>();

        gmaSource.clip = MainJingle;
        gmaSource.Play();
    }
	
	public void HoverNoise()
    {
        UInoiseMaker.clip = hover;
        UInoiseMaker.Play();
    }
}
