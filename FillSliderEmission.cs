using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] // Run in Unity Editor
public class FillSliderEmission : MonoBehaviour
{
    [SerializeField] private float ObjectHeight; // Fill Amount in Shader Graph 
    private Mesh mesh;
    private Material mat;
    [SerializeField] private int indexmat = 1; // Because our object have multi materials

    private void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        mat = GetComponent<MeshRenderer>().materials[indexmat];
    }
    
    private void LateUpdate()
    {
        mat.SetFloat("_Fill", ObjectHeight); // Reference of Fill Proprety in Emission shader Graph
    }
}
