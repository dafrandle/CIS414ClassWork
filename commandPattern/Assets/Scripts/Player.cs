using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Material player_material;

    public float z_start = -49.5f;
    public float x_start = -99.5f;
    public int start_pos_z = 75;
    public int start_pos_x = 0;
    public int z_size = 150;
    public int x_size = 150;
    public GameObject folder;

    private PlayerObject player;
    private const float plane_level = 0.5f;
    private KeyCode up = KeyCode.W;
    private KeyCode down = KeyCode.S;
    private KeyCode left = KeyCode.A;
    private KeyCode right = KeyCode.D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
        {
            player.Move(up);
        }
        else if(Input.GetKeyDown(down))
        {
            player.Move(down);
        }
        else if (Input.GetKeyDown(left))
        {
            player.Move(left);
        }
        else if(Input.GetKeyDown(right))
        {
            player.Move(right);
        }
    }

    private void Awake()
    {
        player = new PlayerObject(player_material, start_pos_x, plane_level, start_pos_z, z_size, x_size, x_start, z_start, folder);
    }

    void OnGUI()
    {
        if (GUILayout.Button("Reset Recoding"))
        {
            player.ResetToStart();
            player.Invoker.Reset();
        }
        if (GUILayout.Button("Back to Start"))
        {
            player.ResetToStart();
        }

        if (!player.Invoker.IsRecording)
        {
            if (GUILayout.Button("Start Recording"))
            {
                player.ResetToStart();
                player.Invoker.Record();
            }
            if (GUILayout.Button("Start Replay"))
            {
                player.ResetToStart();
                player.Invoker.Replay();
            }
            if (GUILayout.Button("Reverse"))
            {
                player.Invoker.Unplay();
            }
        }
        else
        {

            if (GUILayout.Button("Stop Recording"))
            {
                player.Invoker.StopRecord();
            }

        }
    }


}
