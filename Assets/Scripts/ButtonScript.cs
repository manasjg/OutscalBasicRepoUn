using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public Button levelButton;
    public string sceneToLoad;
    void Start()
    {
        levelButton.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
