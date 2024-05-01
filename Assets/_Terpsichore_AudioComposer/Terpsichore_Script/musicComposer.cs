using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicComposer : MonoBehaviour
{
    [Header ("Step 1: Drag 'Songs' prefab into your scene")]
    [Header("Step 2: open up 'Songs' and drag your AudioSources into the slots below.")]
    [Header(" ")]
    //Added the basic type of audio that wil play in a sequence
    public AudioSource _intro; // 1st sound that will play
    public AudioSource _loop; // 2nd song to play in a loop, until leaving the trigger box
    public AudioSource _outro;// last song to play after leaving the trigger box
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !_intro.isPlaying)
        {
            _intro.Play();
            _loop.Stop();
            Debug.Log("Intro Playing");
        }

    }

    void Update()
    {
        if (_intro.isPlaying)
        _loop.Play();
        Debug.Log("Loop Playing");
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && _loop.isPlaying)
        {
            _intro.Stop();
            _loop.Stop();
            _outro.Play();
            Debug.Log("Outro Playing");
        }
    }
}
