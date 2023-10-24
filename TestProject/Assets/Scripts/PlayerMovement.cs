using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float  horizontalSpeed = 10.0f; 
    public float  verticalSpeed = 10.0f;

    
    float xInput;
    float yInput;
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxisRaw("Horizontal"); 
        float yInput = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(xInput * horizontalSpeed, yInput * verticalSpeed);
    }

   

   
}
