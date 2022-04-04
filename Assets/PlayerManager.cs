using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip _clip;

    SoundManager soundManager;

    private bool _isPlaying = false;
    private void Start()
    {
        soundManager = SoundManager.Instance;
    }

    void Update()
    {
        if (Keyboard.current.dKey.isPressed && !soundManager.IsSoundPlaying())
        {
            soundManager.PlaySound(_clip);
        }
    }
}
