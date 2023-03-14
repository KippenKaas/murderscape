using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminManager : MonoBehaviour
{
    public DatabaseManager databaseManager;

    public void CheckAdmin()
    {
        StartCoroutine(databaseManager.GetAdminFromDatabase("Gembertheetje"));
    }

    // public void Signup()
    // {
    //     if(emailInput.text != "" && usernameInput.text != "" && passwordInput.text != "")
    //     {
    //         string email = emailInput.text;
    //         string username = usernameInput.text;
    //         string password = passwordInput.text;
    //         StartCoroutine(databaseManager.InsertPlayerToDatabase(email, username, password));
    //     } else {
    //         Debug.LogError("All fields are required!");
    //     }
    // }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
