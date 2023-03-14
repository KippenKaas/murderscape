using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class PlayerSignup : MonoBehaviour
{

    public MenuManager menuManager;
    public DatabaseManager databaseManager;

    public TMP_InputField registerEmailInput;
    public TMP_InputField registerUsernameInput;
    public TMP_InputField registerPasswordInput;

    public TMP_InputField loginUsernameInput;
    public TMP_InputField loginPasswordInput;

    public Image registerPanel;
    public Image loginPanel;

    // Start is called before the first frame update
    void Update()
    {
        
    }

    public void Signup()
    {
        if(registerEmailInput.text != "" && registerUsernameInput.text != "" && registerPasswordInput.text != "")
        {
            string email = registerEmailInput.text;
            string username = registerUsernameInput.text;
            string password = registerPasswordInput.text;
            StartCoroutine(databaseManager.InsertPlayerToDatabase(email, username, password));
            registerPanel.gameObject.SetActive(false);
            loginPanel.gameObject.SetActive(true);
        } else {
            Debug.LogError("All fields are required!");
        }
    }

    public void Login()
    {
        if(loginUsernameInput.text != "" && loginPasswordInput.text != "")
        {
            string email = registerEmailInput.text;
            string username = registerUsernameInput.text;
            string password = registerPasswordInput.text;
            StartCoroutine(databaseManager.GetPlayerLoginFromDatabase(username, password));
            menuManager.SceneSelector(1);
        } else {
            Debug.LogError("All fields are required!");
        }
    }
}
