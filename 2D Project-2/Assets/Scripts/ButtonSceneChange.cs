using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneChange : MonoBehaviour
{
    public string sceneName;
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}