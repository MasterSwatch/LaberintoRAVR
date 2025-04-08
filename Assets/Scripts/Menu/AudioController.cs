using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; // libreria de audio
using UnityEngine.UI; // liberaria de UI

public class AudioController : MonoBehaviour
{
    public bool musicMute;
    public bool soundMute;
    public bool masterMute;
    public AudioMixer audioMixer;
    public float previusMaster = 0;
    public float previusSound = 0;
    public float previusMusic = 0;
    void Start()
    {
        audioMixer = Resources.Load<AudioMixer>("MainMixed");
    }

    //public float GetLevel(string bus)
    // Update is called once per frame
    void Update()
    {

    }
}
