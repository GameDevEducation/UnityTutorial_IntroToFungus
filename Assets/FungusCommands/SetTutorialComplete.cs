using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Custom", "Set Tutorial Complete", "Marks a tutorial as being complete")]
[AddComponentMenu("")]
public class SetTutorialComplete : Command
{
    [SerializeField] string TutorialID;

    public override void OnEnter()
    {
        PlayerPrefs.SetInt($"{TutorialID}.Complete", 1);
        PlayerPrefs.Save();

        Continue();
    }

    public override string GetSummary()
    {
        return $"Flag {TutorialID} as complete";
    }

    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}
