using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] string nextSceneName;

    public void NextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
