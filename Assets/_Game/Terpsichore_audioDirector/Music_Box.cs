using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "0_Music_Director_", menuName = "_Terpsichore_V2_")]
public class SoundSystemData : ScriptableObject
{
    [Header("Add your Music Sequences Here")]

    //Drag your AudioClips intto the playlist
    [SerializeField] private AudioClip _intro;
    [SerializeField] private AudioClip _loop;
    [SerializeField] private AudioClip _outro;

    [Header("Who will trigger the audio")]

    //Character to trigger audio
    [SerializeField] private GameObject _player;

    public List<AudioClip> Plalist => _musicSequences;



    public AudioClip MusicPlay()
    {
        if(GameObject =!null)
    }

    private void Awake()
    {


    }
}
