using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private CaptureTheFlag_Rules captureTheFlagRulesScript;

    //Security for trigger only one time
    private bool flagIsCaptured = false;

    private void Start()
    {
        captureTheFlagRulesScript = GetComponentInParent<CaptureTheFlag_Rules>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !flagIsCaptured)
        {
            flagIsCaptured = true;
            captureTheFlagRulesScript.FlagCaptured();
        }
    }
}
