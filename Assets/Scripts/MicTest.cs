using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent (typeof (AudioSource))]
public class MicTest : MonoBehaviour {
	AudioSource _audioSource;

	// Mic input
	public string _selectedDevice;


	// Use this for initialization
	void Start () {
		_audioSource = GetComponent<AudioSource>();

		// by default select first device
		_selectedDevice = Microphone.devices[0].ToString();
		Debug.Log("Selected device:" + _selectedDevice);


		_audioSource.clip = Microphone.Start(_selectedDevice, true, 10, 44100);
		_audioSource.loop = true;



		while (!(Microphone.GetPosition(null) > 0)){}

		_audioSource.Play();
	}

	// Update is called once per frame
	void Update () {

	}
}
