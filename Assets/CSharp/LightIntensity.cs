using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour
{
    private Light dirLight;

    void Start()
    {
        dirLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            dirLight.intensity = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            dirLight.intensity = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            dirLight.intensity = 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            dirLight.intensity = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            dirLight.intensity = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            dirLight.intensity = 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            dirLight.intensity = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            dirLight.intensity = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            dirLight.intensity = 1.5f;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            dirLight.intensity = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            dirLight.intensity = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            dirLight.intensity = 1.5f;
        }
    }
}
