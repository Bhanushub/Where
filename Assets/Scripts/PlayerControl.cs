using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float movSpeed = 5f;
    Vector3 movDirection;
    Rigidbody rb;
    private float HorizontalMov;
    private float VerticalMov;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMov = Input.GetAxis("Horizontal");
        VerticalMov = Input.GetAxis("Vertical");

        movDirection = (VerticalMov * transform.forward + HorizontalMov * transform.right).normalized;

    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 yVel = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = movDirection * movSpeed * Time.deltaTime;
        Debug.Log("Direction " + movDirection);
        rb.velocity += yVel;
    }
}
