using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rahat : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    private void Awake()
    {
        Debug.Log("Awake");
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
