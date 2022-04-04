using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField]
    private AudioSource _audioSource, _effectSource;
    [SerializeField]
    private float volume;

    void Awake()
    {
        // If the instance 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    private void Start()
    {
        _audioSource.volume = volume;
        _effectSource.volume = volume;
    }

    public bool IsSoundPlaying()
    {
        return _effectSource.isPlaying;
    }

    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }
    
}
