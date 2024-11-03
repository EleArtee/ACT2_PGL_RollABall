using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private bool OnGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        OnGround = true;
    }

    private void OnMove(InputValue inputValue)
    {
        Vector2 movement = inputValue.Get<Vector2>();

        movementX = movement.x;
        movementY = movement.y;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            score.scoreCount += 1;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            OnGround = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround)
        {
            rb.AddForce(Vector3.up * 300);
            OnGround = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(movementX, 0, movementY);
        rb.AddForce(movement * speed);


    }
}
