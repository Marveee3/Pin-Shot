using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pinPrefab;

    // Update is called once per frame
    void Update()
    {
        // Check for mouse click or touch input
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump") || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            SpawnPin();
        }
    }

    private void SpawnPin()
    {
        // Instantiate the pin at the current position and rotation
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}