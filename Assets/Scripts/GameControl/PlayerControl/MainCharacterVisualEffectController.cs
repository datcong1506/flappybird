using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class MainCharacterVisualEffectController : MonoBehaviour
{
    [SerializeField] private VisualEffect effect;
    // Start is called before the first frame update
    public void Play()
    {
        effect.Play();
    }
}
