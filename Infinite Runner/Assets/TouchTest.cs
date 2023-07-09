using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchTest : MonoBehaviour
{


    public void Click()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
