using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Custom", "Show Message After Delay", "Shows a message after a delay")]
[AddComponentMenu("")]
public class ShowMessageAfterDelay : Command
{
    [SerializeField] float Delay;
    [SerializeField] string Message;

    IEnumerator WaitForDelay()
    {
        yield return new WaitForSeconds(Delay);

        Debug.LogWarning(Message);

        Continue();
    }

    public override void OnEnter()
    {
        StartCoroutine(WaitForDelay());
    }

    public override string GetSummary()
    {
        return $"In {Delay}s log message: {Message}";
    }

    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}

