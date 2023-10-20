using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float  horizontalSpeed = 10.0f; 
    public float  verticalSpeed = 10.0f;
    Rigidbody2D rb; 
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal"); 
        float yInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput * horizontalSpeed, yInput * verticalSpeed);
    }
}
