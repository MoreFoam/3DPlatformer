using UnityEngine;
using System.Collections;
#pragma strict
public class Fps : MonoBehaviour
{

    // Use this for initialization
    void Awake()
    {
        Application.targetFrameRate = 300;
        QualitySettings.vSyncCount = 0;
    }
}
