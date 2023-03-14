using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GitHandler : MonoBehaviour
{
    [MenuItem("Murderscape/InsertGit ^s")]
    public static void InsertGit()
    {
        Debug.Log("Starting Insert GitHub...");
        System.Diagnostics.Process.Start("CMD.exe", "/C git add Assets/*");
        System.Diagnostics.Process.Start("CMD.exe", "/C git commit -a -m 'update'");
        System.Diagnostics.Process.Start("CMD.exe", "/C git push origin master");
    } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
