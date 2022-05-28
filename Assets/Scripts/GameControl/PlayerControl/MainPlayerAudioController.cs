using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class MainPlayerAudioController : AbStatePatternDependencyStateSelf
{
    private AudioSource _audioSource=>GetComponent<AudioSource>();

    public AudioClip flyClip;
    public AudioClip hitClip;
    public AudioClip diedClip;
    public void OnFly()
    {
        _audioSource.volume = SimpleSecssionScripableObject.Singleton.volume;
        _audioSource.PlayOneShot(flyClip);
    }
    
    
    public override ResponseEvent TriggerEvent(GameEvent gameEvent)
    {
        switch (gameEvent)
        {
            case GameEventChangeStateEvent _gameEventChangeState:
                switch (_gameEventChangeState.newState)
                {
                    case MainCharacterFlyState mainCharacterFlyState:
                        mainCharacterFlyState.onFlyUpEvent.AddListener(OnFly);
                        break;
                    case MainCharacterDieState _:
                        //set animation
                        _audioSource.PlayOneShot(hitClip);
                        if (transform.position.y > 1.5f)
                        {
                            StartCoroutine(PlayDie());
                        }
                        break;
                }
                break;
        }
    
        return null;
    }

    IEnumerator PlayDie()
    {
        yield return new WaitForSeconds(0.4f);
        _audioSource.PlayOneShot(diedClip);
    }
    
}
