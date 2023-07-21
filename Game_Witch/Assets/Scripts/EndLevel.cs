using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameObject size;
    float scale = 1f;

    void Update()
    {
        if (scale < 12f)
        {
            size.transform.localScale = new Vector3(23f, scale, 1f);
            scale += 0.1f;
        }
    }
}
