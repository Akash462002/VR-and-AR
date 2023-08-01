using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    public Transform Loadingbar;

    [SerializeField]
    private float start;
    [SerializeField]
    private float end;

// Update is called once per frame
    void Update () { 
        if (start < 108) {
            start += end * Time.deltaTime;
            Debug.Log ((int)start);
            } else {
                Application.LoadLevel ("ui 1");
            }

       Loadingbar.GetComponent<Image> ().fillAmount = start / 100;

    }
}
