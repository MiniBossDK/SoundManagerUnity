using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip _clip;

    private bool _isPlaying = false;

    SoundManager soundManager;
    private void Start()
    {
        soundManager = SoundManager.Instance;
    }

    void Update()
    {
        if (Keyboard.current.aKey.isPressed && !soundManager.IsSoundPlaying())
        {
            soundManager.PlaySound(_clip);
        }
    }
}
