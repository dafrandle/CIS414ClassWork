using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private bool is_recording;
    private bool is_replaying;

    private List<IAction> recorded_actions= new List<IAction>();

    public bool IsRecording { get => is_recording; }
    public bool IsReplaying { get => is_replaying; }

    public bool IsRecordedActions()
    {
        if (recorded_actions.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public void ExecuteCommand(IAction action)
    {
        if (is_recording)
        {
            recorded_actions.Add(action);
        }
        action.Execute();

        Debug.Log($"Executed command: {action}");
    }

    public void Record()
    {
        is_recording = true;
    }
    public void StopRecord()
    {
        is_recording = false;
    }
    public void Reset()
    {
        recorded_actions.Clear();
    }

    public void Replay()
    {
        is_replaying = true;

        if(recorded_actions.Count > 0)
        {
            foreach(var action in recorded_actions)
            {
                action.Execute();
                Debug.Log($"Replay - Executed command: {action}");
            }
        }
        else
        {
            Debug.Log("Nothing to replay");
        }

        is_replaying = false;
    }

    public void Unplay()
    {

        if(recorded_actions.Count > 0)
        {
            for(int i = recorded_actions.Count - 1; i >= 0; i--)
            {
                recorded_actions[i].Undo();
                Debug.Log($"Unplay command {recorded_actions[i]}");
            }
        }
        else
        {
            Debug.Log("Nothing to unplay");
        }
    }
}