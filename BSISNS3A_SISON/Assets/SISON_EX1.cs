using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SISON_EX1 : MonoBehaviour
{
    public float rotationSpeed = 15f;

    private void Awake()
    {
        Debug.Log("I AM AWAKE");
    }

    private void OnEnable()
    {
        Debug.Log("I AM ENABLED");
    }

    private void OnDisable()
    {
        Debug.Log("I AM DISABLED");
    }

    void Start()
    {
        Debug.Log("COMPONENT STARTED");
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnDestroy()
    {
        Debug.Log("I AM DESTROYED");
    }

}
