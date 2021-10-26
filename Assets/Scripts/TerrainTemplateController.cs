﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainTemplateController : MonoBehaviour
{
    private const float debugLineHeight = 10.0f;

    private void onDrawGizmos()
    {
        Debug.DrawLine(transform.position + Vector3.up * debugLineHeight / 2, transform.position + Vector3.down * debugLineHeight / 2, Color.green);
    }
}
