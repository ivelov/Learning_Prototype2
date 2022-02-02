using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeDelay = 2;
    private float timePassed;

    private void Start()
    {
        timePassed = timeDelay;
    }

    void Update()
    {
        timePassed += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timePassed >= timeDelay)
        {
            timePassed = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
