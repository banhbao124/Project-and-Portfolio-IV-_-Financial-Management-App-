using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void LoginButton()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitButton()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void SettingButton()
    {
        SceneManager.LoadSceneAsync(3);

    }
    public void SpendingsButton()
    {
        SceneManager.LoadSceneAsync(1);

    }
    public void DebtsButton()
    {
        SceneManager.LoadSceneAsync(2);

    }
}


