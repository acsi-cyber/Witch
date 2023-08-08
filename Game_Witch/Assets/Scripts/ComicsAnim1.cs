using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicsAnim1 : MonoBehaviour
{
    public Vector3 minScale;
    public Vector3 maxScale;
    public float scalingSpeed;
    public float scalingDuration;

    public IEnumerator CorutinStart()
    {
        yield return RepeatLerping(minScale, maxScale, scalingDuration);
    }

    IEnumerator RepeatLerping(Vector3 startScale, Vector3 endScale, float time)
    {
        float t = 0.0f;
        float rate = (1f / time) * scalingSpeed;
        while (t < 1f)
        {
            t += Time.deltaTime * rate;
            transform.position = Vector3.Lerp(startScale, endScale, t);
            yield return null;
        }
        Debug.Log(gameObject.name);
        ComicsMeneger.sceil += 1;
        FindObjectOfType<ComicsMeneger>().SwitchStart();
    }

}
