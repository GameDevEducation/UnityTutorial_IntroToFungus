using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Custom", "Clear Tutorial Complete Flags", "Clears the tutorial completion flags")]
[AddComponentMenu("")]
public class ClearTutorialCompleteFlags : Command
{
    [SerializeField] List<string> TutorialIDs;

    public override void OnEnter()
    {
        // clear the status of the tutorial completion flags
        var linkedFlowchart = GetFlowchart();
        foreach (var tutorialID in TutorialIDs)
        {
            PlayerPrefs.SetInt($"{tutorialID}.Complete", 0);
            linkedFlowchart.SetBooleanVariable($"{tutorialID}Complete", false);
        }

        PlayerPrefs.Save();

        Continue();
    }

    public override string GetSummary()
    {
        return "Clear Tutorial Completion Flags";
    }

    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}