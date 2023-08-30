using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public GameObject object1;
    public GameObject StartPos;
    public GameObject EndPos;
    public Vector3 PosEnd;
    public Vector3 PosStart;
    float x1;
    float y1;
    float z1;
    int i = 0;

    private void Update()
    {
        x1 = StartPos.transform.position.x;
        y1 = StartPos.transform.position.y;
        z1 = StartPos.transform.position.z;
        PosStart.Set(x1, y1, z1);
        x1 = EndPos.transform.position.x;
        y1 = EndPos.transform.position.y;
        z1 = EndPos.transform.position.z;
        PosEnd.Set(x1, y1, z1);
        if (i == 0)
        {
            StartCoroutine(CorutinStart());
            i = 1;
        }
    }

    public IEnumerator CorutinStart()
    {
        float t = 0.0f;
        float rate = (1f / 6) * 1;
        while (t < 1f)
        {
            t += Time.deltaTime * rate;
            object1.transform.position = Vector3.Lerp(PosStart, PosEnd, t);
            yield return null;
        }
    }
}
