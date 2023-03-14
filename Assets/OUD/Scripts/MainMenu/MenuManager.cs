using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    // public GameObject quitPanel;

    public void SceneSelector(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
        Debug.Log("Succesfully Loaded Lobby Selector");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // public void DeactivateQuitPanel()
    // {
    //     quitPanel.SetActive(false);
    //     Debug.Log("Deactivated the Quit Panel succesfully");
    // }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Main Menu Succesfully Loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
