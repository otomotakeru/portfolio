﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFps : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 120;
    }
}
