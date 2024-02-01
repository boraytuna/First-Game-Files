using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerOne")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        
        }

    }
    
}
