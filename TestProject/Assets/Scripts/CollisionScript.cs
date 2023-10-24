using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D()
    {
        Debug.Log("OnCollisionEnter2D");
    }
    
    private void OnCollisionExit2D()
    {
        Debug.Log("OnCollisionExit2D");
    }

    private void OnCollisionStay2D()
    {
        Debug.Log("OnCollisionStay2D");
    }
}
