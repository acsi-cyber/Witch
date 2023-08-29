using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComicsAnim1 : MonoBehaviour
{
    private Vector3 minScale;
    private Vector3 maxScale;
    public float scalingSpeed;
    public float scalingDuration;
    public GameObject startPos;
    public GameObject endPos;
    float x1;
    float y1;
    float z1;

    public IEnumerator CorutinStart()
    {
        x1 = startPos.transform.position.x;
        y1 = startPos.transform.position.y;
        z1 = startPos.transform.position.z;
        minScale.Set(x1, y1, z1);
        x1 = endPos.transform.position.x;
        y1 = endPos.transform.position.y;
        z1 = endPos.transform.position.z;
        maxScale.Set(x1, y1, z1);

        yield return RepeatLerping(minScale, maxScale, scalingDuration);
    }

    public IEnumerator RepeatLerping(Vector3 startScale, Vector3 endScale, float time)
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
