using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string nextlevelName;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene(nextlevelName);
        }
        
    }
}
