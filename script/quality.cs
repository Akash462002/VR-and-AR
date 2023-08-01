using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class quality : MonoBehaviour
{
    public AudioMixer mainMixer;

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);

    }
   
}
