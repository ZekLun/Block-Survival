using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float distance = 1f;
    void Update()
    {
        var camPosition = transform.position;
        camPosition.z = player.position.z - distance;
        camPosition.x = player.position.x;
        camPosition.y = player.position.y;
        transform.position = camPosition;
    }
}
