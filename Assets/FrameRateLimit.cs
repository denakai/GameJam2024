using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateLimit : MonoBehaviour
{
    public enum limits
    {
        noLimit = 0,
        limit60 = 60,
    }
    public limits limit;

    void Awake()
    {
        Application.targetFrameRate = (int)limit;
    }
}
