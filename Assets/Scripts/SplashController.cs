using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    public float splashTime = 0.2f;

    void Start()
    {
        StartCoroutine(ShowSplashScreen());
    }

    IEnumerator ShowSplashScreen()
    {
        yield return new WaitForSeconds(splashTime);

        SceneManager.LoadScene("FirstScene");
    }
}
