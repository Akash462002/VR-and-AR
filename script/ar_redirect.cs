using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ar_redirect : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("AR");
    }
}
