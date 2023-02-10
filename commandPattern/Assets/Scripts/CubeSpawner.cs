using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Material wall_material;

    public float z_start = -49.5f;
    public float x_start = -99.5f;
    public int z_size = 150;
    public int x_size = 150;

    private const float plane_level = 0.5f;
    private CubeObject[,] plane;


    private void Awake()
    {
        plane = new CubeObject[z_size, x_size];
        InstantiateMap(plane);
    }

    private void InstantiateMap(CubeObject[,] plane)
    {
        for(int z = 0; z < z_size; z++)
        {
            for(int x = 0; x < x_size; x++) {
                float z_value = z_start + z;
                float x_value = x_start + x;
                plane[z, x] = new CubeObject(wall_material);
                plane[z, x].Create(x_value, plane_level, z_value);
            }
        }
    }



    





}
