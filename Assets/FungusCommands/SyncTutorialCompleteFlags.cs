using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[CommandInfo("Custom", "Sync Tutorial Complete Flags", "Synchronises the tutorial completion flags")]
[AddComponentMenu("")]
public class SyncTutorialCompleteFlags : Command
{
    [SerializeField] List<string> TutorialIDs;

    public override void OnEnter()
    {
        // update the status of the tutorial completion flags
        var linkedFlowchart = GetFlowchart();
        foreach(var tutorialID in TutorialIDs)
        {
            bool isComplete = PlayerPrefs.GetInt($"{tutorialID}.Complete", 0) == 1;

            linkedFlowchart.SetBooleanVariable($"{tutorialID}Complete", isComplete);
        }

        Continue();
    }

    public override string GetSummary()
    {
        return "Synchronise Tutorial Completion Flags";
    }

    public override Color GetButtonColor()
    {
        return new Color32(191, 235, 195, 255);
    }
}