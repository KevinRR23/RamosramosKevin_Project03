using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu (fileName = "0_Audio_Director_", menuName = "_Terpsichore_" )]
public class SoundSystemData : ScriptableObject
{
    [Header("Add your Music Sequences Here")]

    //Drag your AudioClips intto the playlist
    [SerializeField] private List<AudioClip> _musicSequences;

    [Header("Who will trigger the audio")]

    //Character to trigger audio
    [SerializeField] private GameObject _player;

    public List<AudioClip> Plalist => _musicSequences;



    public AudioClip GetSongFromPlaylist()
    {
        int randomIndex = Random.Range(0, _musicSequences.Count);
        AudioClip newSong = _musicSequences[0];
        return newSong;
    }

    private void Start()
    {
     
    }
}
