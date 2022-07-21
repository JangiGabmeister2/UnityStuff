using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject codePreFab;
    public Vector3 spawnLocation;
        
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) == true)
        {
            Instantiate(codePreFab, spawnLocation, Quaternion.identity);    
        }
        
        
    }
}
