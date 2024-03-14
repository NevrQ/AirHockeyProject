using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puk : MonoBehaviour
{
    Camera mainCamera;
    Rigidbody2D rb;

    private void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var viewportPos = mainCamera.WorldToViewportPoint(transform.position);

        if (viewportPos.x < 0 || viewportPos.x > 1 || viewportPos.y < 0 || viewportPos.y > 1)
        {
            transform.position = new Vector3();
            rb.velocity = new Vector2();
        }
    }
}
