using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstSceneChange : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("ListMenu");
    }
}
