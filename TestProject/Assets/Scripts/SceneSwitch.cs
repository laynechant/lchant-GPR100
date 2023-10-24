using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneName;


    private void Update()
    {
        // 0 is left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            SwitchScene();
        }
    }
    void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
