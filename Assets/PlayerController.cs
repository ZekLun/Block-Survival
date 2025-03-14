using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movementDirection;
    float angle = 0;

    [SerializeField] private float movementSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (movementDirection != Vector2.zero)
        {
            angle = -Vector2.Angle(movementDirection, Vector2.up) * Mathf.Sign(movementDirection.x);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;

        rb.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
