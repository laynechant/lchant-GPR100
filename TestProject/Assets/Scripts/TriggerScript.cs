using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        Debug.Log("OnTriggerEnter2D");
    }

    private void OnTriggerExit2D()
    {
        Debug.Log("OnTriggerExit2D");
    }

    private void OnTriggerStay2D()
    {
        Debug.Log("OnTriggerStay2D");
    }
}
