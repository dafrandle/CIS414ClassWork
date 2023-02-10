using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{
    private Material material;
    private GameObject cube; //GameObject.CreatePrimitive(PrimitiveType.Cube);

    public Material Material { get { return material; } set { material = value; } }

    public CubeObject(Material material)
    {
        Material = material;
    }

    public void Create(float x, float y, float z)
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.SetActive(false);
        cube.GetComponent<Renderer>().material = material;
        cube.transform.position= new Vector3(x, y, z);
        cube.SetActive(true);
    }

    public void Delete()
    {
        Destroy(cube);
    }
}
