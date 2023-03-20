using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class CubeObject : MonoBehaviour
{
    private Material material;
    private GameObject cube; //GameObject.CreatePrimitive(PrimitiveType.Cube);
    private bool deleted = true;

    public Material Material { get { return material; } set { material = value; } }

    public CubeObject(Material material)
    {
        Material = material;
    }

    public void Create(float x, float y, float z, GameObject folder)
    {
        if (!deleted)
        {
            Delete();
        }
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.SetActive(false);
        cube.transform.parent = folder.transform;
        cube.GetComponent<Renderer>().material = material;
        cube.transform.position = new Vector3(x, y, z);
        cube.SetActive(true);
        deleted = false;
    }

    public void Delete()
    {
        if (!deleted)
        {
            Destroy(cube);
            deleted = true;
        }
    }
}
