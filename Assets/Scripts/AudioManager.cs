using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----------------AudioSource_Source----------------")]
    [SerializeField] AudioSource MusicSound;
    [SerializeField] AudioSource SFXSound;

    [Header("----------------AudioSource_Clip----------------")]
    public AudioClip Begin;
    public AudioClip Eat;
    public AudioClip Death;
    public AudioClip Cherry;
    public AudioClip Bonus;
    public AudioClip Ghost;
    public AudioClip BackGround;


    private void Start()
    {
        MusicSound.clip = BackGround;
        MusicSound.Play();
    }

    public void PlaySound(AudioClip clip)
    { 
        SFXSound.PlayOneShot(clip);
    }
}
