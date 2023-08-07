using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class TimeEffect : MonoBehaviour
{
    public Vector3 minScale;
    public Vector3 maxScale;
    public float scalingSpeed;
    public float scalingDuration;
    public static float timeSpeedUp = 8f;
    public static float timeSpeedDown = 2f;
    float timeScale;

    public IEnumerator TimeChek()
    {
        if(gameObject.name == "timeSpeedUp")
        {
            timeScale = timeSpeedUp;
        }
        else if(gameObject.name == "timeSpeedDown")
        {
            timeScale = timeSpeedDown;
        }
        yield return RepeatLerping(maxScale, minScale, scalingDuration);
    }

    IEnumerator RepeatLerping(Vector3 startScale, Vector3 endScale, float time)
    {
        float t = 0.0f;
        float rate = (1f / timeScale) * scalingSpeed;
        while (t < 1f)
        {
            t += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
            yield return null;
        }
        transform.localScale = Vector3.Lerp(startScale, endScale, 0);
        timeScale = 0;
    }

}
