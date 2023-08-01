using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_settings : MonoBehaviour
{
    
    public void LoadScene()
    {
        SceneManager.LoadScene("Settings");
    }
}
