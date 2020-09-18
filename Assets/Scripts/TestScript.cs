using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("My first game awake function");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My first game start function");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F pressed down");
        }
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("F pressed");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F released");
        }
    }

    private void LateUpdate()
    {
        
    }
    private void OnDestroy()
    {
        
    }
}
