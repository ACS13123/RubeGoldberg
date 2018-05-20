using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

    private void OnMouseUp()
    {
        if (gameObject.tag == "Start")
        {
            SceneManager.LoadScene("the start");
        }
        if (gameObject.tag == "Finish")
        {
            Application.Quit();
        }
    }
}
