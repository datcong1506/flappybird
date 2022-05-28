using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;



public enum GameState
{
    PlayerDied,
    IsPlaying,
}

public class Gamemanager : MonobehaviourSingletonInterface<Gamemanager>
{
    
    public UnityEvent OnEndSecssionEvent;
    public  UnityEvent OnStartPlayingEvent;

    public GameState MainGameState;
    
    
    
    public void StartGame()
    {
        var character=GameObject.FindObjectOfType<MainCharacterFSM>();
        if (character != null)
        {
            character.ChangeState(new GameEventChangeStateEvent
            {
                origin = this.gameObject,
                newState = character.GetComponent<MainCharacterFlyState>(),
            });
            MainGameState = GameState.IsPlaying;
            OnStartPlayingEvent?.Invoke();
        }
    }
    
    public void OnEndSecssion()
    {
        MainGameState = GameState.PlayerDied;
        OnEndSecssionEvent?.Invoke();
    }



    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }

    public void SetTimeScale(float value)
    {
        Time.timeScale = value;
    }


    public void Replay()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
   

}

