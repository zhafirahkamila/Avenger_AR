using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonController : MonoBehaviour
{
    public void BackButton(string ButtonName)
    {
        if (ButtonName == "BackButtonCaptain")
        {
            SceneManager.LoadScene("ListMenu");
        }
        else if (ButtonName == "BackButtonIronMan")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "BackButtonSpiderMan")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "BackButtonHawkeye")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "BackButtonBlackWidow")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "BackButtonThor")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "BackButtonHulk")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "BackButtonWanda")
        {
            SceneManager.LoadScene("ListMenu");
        }else if(ButtonName == "ScanCamera")
        {
            SceneManager.LoadScene("ListMenu");
        }
        else
        {
            print("Error...");
        }
    }
}
