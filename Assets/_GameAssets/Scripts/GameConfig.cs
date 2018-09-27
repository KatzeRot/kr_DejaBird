using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig
{
    private static bool playing = true;

    public static bool IsPlaying()
    {
        return playing;
    }
    public static void StartGame()
    {
        playing = true;
    }
    public static void StopGame()
    {
        playing = false;
    }
}