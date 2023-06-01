using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public void ToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
