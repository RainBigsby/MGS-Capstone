using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shootTopDown : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        // check if spacebar is pressed
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // spawn bullet
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }
}
