using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureTheFlag_Rules : MonoBehaviour
{
    /// <summary>
    /// By Antoine LEROUX
    /// This script reference the rules of mini-game Capture the flag
    /// </summary>

    public void FlagCaptured()
    {
        //Call here the function win from MiniGameManager
        Debug.Log("Win");
    }
}
