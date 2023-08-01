using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class vr_redirect : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("VR");
    }
}
