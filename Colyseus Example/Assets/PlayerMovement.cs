using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool moving = false;
    public float speed = 10f;
    private Vector2 targetPosition;
    private NetworkManager _networkManager = null;

    public void Start()
    {
        _networkManager = gameObject.AddComponent<NetworkManager>();
        _networkManager.JoinGame();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != targetPosition)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, step);
        }
        else
        {
            moving = false;
        }
    }
}
