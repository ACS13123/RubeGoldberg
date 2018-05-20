using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    private void OnMouseUp()
    {
        if (gameObject.tag == "Restart")
        {
            SceneManager.LoadScene("Menu");
        }
        if (gameObject.tag == "Finish")
        {
            Application.Quit();
        }
    }
}