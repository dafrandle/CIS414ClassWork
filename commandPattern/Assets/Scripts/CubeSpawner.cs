using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Material wall_material;

    public float z_start = -49.5f;
    public float x_start = -99.5f;
    public int z_size = 150;
    public int x_size = 150;
    public int path_start_z = 75;
    public int path_start_x = 75;
    public GameObject folder;

    private const float plane_level = 0.5f;
    private CubeObject[,] plane;


    private void Awake()
    {
        plane = new CubeObject[z_size, x_size];
        InstantiateMap(plane);
        x_crawl(path_start_z, plane); // starts at a z coord and crawls in the x direction
        z_crawl(path_start_x, plane); // starts at an x coord and crawls in the z direction

    }

    private void x_crawl(int start, CubeObject[,] plane)
    {
        int x_pos = 0;
        int z_pos = start;
        plane[z_pos, x_pos].Delete();
        while (x_pos < x_size - 1)
        {
            int z_move;
            int x_move;
            if (z_pos == 0)
            {
                z_move = UnityEngine.Random.Range(0, 2);
            }
            else if (z_pos == z_size - 1)
            {
                z_move = UnityEngine.Random.Range(-1, 1);
            }
            else
            {
                z_move = UnityEngine.Random.Range(-1, 2);
            }
            if (z_move == 0)
            {
                x_move = 1;
            }
            else
            {
                x_move = 0;
            }
            x_pos += x_move;
            z_pos += z_move;
            Debug.Log($"X_Crawl - Deleting [{z_pos},{x_pos}]");
            plane[z_pos, x_pos].Delete();
        }
    }

    private void z_crawl(int start, CubeObject[,] plane)
    {
        int x_pos = start;
        int z_pos = 0;
        plane[z_pos, x_pos].Delete();
        while (z_pos < z_size - 1)
        {
            int z_move;
            int x_move;
            if (x_pos == 0)
            {
                x_move = UnityEngine.Random.Range(0, 2);
            }
            else if (x_pos == z_size - 1)
            {
                x_move = UnityEngine.Random.Range(-1, 1);
            }
            else
            {
                x_move = UnityEngine.Random.Range(-1, 2);
            }
            if (x_move == 0)
            {
                z_move = 1;
            }
            else
            {
                z_move = 0;
            }
            x_pos += x_move;
            z_pos += z_move;
            Debug.Log($"Z_Crawl - Deleting [{z_pos},{x_pos}]");
            plane[z_pos, x_pos].Delete();
        }
    }

    private void InstantiateMap(CubeObject[,] plane)
    {
        for(int z = 0; z < z_size; z++)
        {
            for(int x = 0; x < x_size; x++) {
                float z_value = z_start + z;
                float x_value = x_start + x;
                plane[z, x] = new CubeObject(wall_material);
                plane[z, x].Create(x_value, plane_level, z_value, folder);
            }
        }
    }



    





}
