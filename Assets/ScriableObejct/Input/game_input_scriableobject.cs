using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "game_input_scriableobject", menuName = "scriptableObjects/game_input_scriableobject")]
public class game_input_scriableobject : ScripableSingletonInterface<game_input_scriableobject>
{
    private Gameinput game_input;

    public Gameinput Game_input
    {
        get
        {
            if (game_input == null)
            {
                game_input = new Gameinput();
            }
            return game_input;
        }
    }
}
