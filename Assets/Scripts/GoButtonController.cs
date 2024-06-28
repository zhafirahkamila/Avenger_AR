using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoButtonController : MonoBehaviour
{
    public void GoButton(string buttonName)
    {
        if (buttonName == "ButtonCaptainAmerica")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }else if (buttonName == "ButtonIronMan")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
        else if (buttonName == "ButtonHulk")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
        else if (buttonName == "ButtonThor")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
        else if (buttonName == "ButtonSpiderMan")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
        else if (buttonName == "ButtonHawkeye")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
        else if (buttonName == "ButtonBlackWidow")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
        else if (buttonName == "ButtonScarletWitch")
        {
            SceneManager.LoadScene("ScanCameraScene");
        }
    }
}
