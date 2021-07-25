﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    private float DesignOrthographicSize;
    private float DesignAspect;
    private float DesignWidth;

    public float DesignAspectHeight;
    public float DesignAspectWidth;

    public void Awake()
    {
        this.DesignOrthographicSize = this.GetComponent<Camera>().orthographicSize;
        this.DesignAspect = this.DesignAspectHeight / this.DesignAspectWidth;
        this.DesignWidth = this.DesignOrthographicSize * this.DesignAspect;

        this.Resize();
    }

    public void Resize()
    {
        float wantedSize = this.DesignWidth / this.GetComponent<Camera>().aspect;
        this.GetComponent<Camera>().orthographicSize = Mathf.Max(wantedSize,
            this.DesignOrthographicSize);
    }
}
