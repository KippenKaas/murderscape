using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DatabaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator InsertPlayerToDatabase(string email, string username, string password)
    {
        string url = "http://localhost/murderscape/scripts/DatabaseRequests.php?username=" + username + "&password=" + password + "&email=" + email + "&function=insertplayer";
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        form.AddField("email", email);
        using(UnityWebRequest www = UnityWebRequest.Post(url, form))
        {
            yield return www.SendWebRequest();
            if(www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(www.error);
            }
        }
    }

    public IEnumerator GetPlayerFromDatabase(string username)
    {
        string url = "http://localhost/murderscape/scripts/DatabaseRequests.php?username=" + username + "&function=getplayer";
        UnityWebRequest hs_get = UnityWebRequest.Get(url);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
        {
            Debug.LogError("Player Doesnt Exist");
        }
    }

    public IEnumerator GetPlayerLoginFromDatabase(string username, string password)
    {
        string url = "http://localhost/murderscape/scripts/DatabaseRequests.php?username=" + username + "&password=" + password + "&function=getplayerlogin";
        UnityWebRequest hs_get = UnityWebRequest.Get(url);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
        {
            Debug.LogError("Player Doesnt Exist");
        }
    }

    public IEnumerator GetAdminFromDatabase(string username)
    {
        string url = "http://localhost/murderscape/scripts/DatabaseRequests.php?username=" + username + "&function=getadmin";
        UnityWebRequest hs_get = UnityWebRequest.Get(url);
        yield return hs_get.SendWebRequest();
        if (hs_get.error != null)
        {
            Debug.LogError(username + "is not an admin");
        }
    }
}
