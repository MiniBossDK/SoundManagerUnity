using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HelperManager : MonoBehaviour
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
        if (Keyboard.current.wKey.isPressed && !soundManager.IsSoundPlaying())
        {
            soundManager.PlaySound(_clip);
        }
    }
}
