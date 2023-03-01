using Assets.Scripts;
using Assets.Scripts.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    private Material material;
    private GameObject player; //GameObject.CreatePrimitive(PrimitiveType.Cube);
    private int z_max;
    private int x_max;
    private float y_base;
    private float z_base;
    private float x_base;
    private int x_start;
    private int z_start;
    private Invoker invoker = new Invoker();

    public Material Material { get { return material; } set { material = value; } }

    public GameObject Player { get { return player; } set { player = value; } }

    public Invoker Invoker { get { return invoker; } set { invoker = value; } }

    public PlayerObject(Material material, int start_x, float start_y, int start_z, int z_max, int x_max, float x_offset, float z_offset, GameObject folder)
    {
        y_base = start_y;
        z_base = z_offset;
        x_base = x_offset;
        z_start = start_z;
        x_start = start_x;
        this.z_max = z_max;
        this.x_max = x_max;

        Material = material;
        Player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        Player.SetActive(false);
        Player.transform.parent = folder.transform;
        Player.GetComponent<Renderer>().material = material;
        Player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        Player.transform.localPosition = new Vector3((x_base + x_start), y_base, (z_base + z_start));
        Player.SetActive(true);
    }

    public void Move(KeyCode direction)
    {
        IAction action = null;
        switch (direction)
        {
            case KeyCode.W: //z +1
                action = new ActionForward(this);
                break;
            case KeyCode.S: //z -1
                action = new ActionBack(this);
                break;
            case KeyCode.A: // x -1
                action = new ActionLeft(this);
                break;
            case KeyCode.D: // x +1
                action= new ActionRight(this);
                break;
            default:
                break;
        }
        if(action != null)
        {
            invoker.ExecuteCommand(action);
        }
    }

    public bool CheckMove(Vector3 move)
    {
        Vector3 position = Player.transform.position;
        Collider[] intersecting = Physics.OverlapSphere(position + move, 0.01f);
        // Debug.Log($"{position} move {move} to {position + move}");
        if (intersecting.Length > 0) { return false; } else { return true; }
    }

    public void ResetToStart()
    {
        Player.transform.localPosition = new Vector3((x_base + x_start), y_base, (z_base + z_start));
    }




}
