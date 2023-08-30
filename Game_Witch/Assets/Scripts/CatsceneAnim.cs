using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsceneAnim : MonoBehaviour
{
    public GameObject object1;
    public GameObject EndPos;
    public Vector3 PosEnd;
    public Vector3 PosStart;
    float x1;
    float y1;
    float z1;

    private void Start()
    {
        x1 = object1.transform.position.x;
        y1 = object1.transform.position.y;
        z1 = object1.transform.position.z;
        PosStart.Set(x1, y1, z1);
        x1 = EndPos.transform.position.x;
        y1 = EndPos.transform.position.y;
        z1 = EndPos.transform.position.z;
        PosEnd.Set(x1, y1, z1);
        Invoke("rt", 0.1f);
    }
    void rt()
    {
        StartCoroutine(CorutinStart());
    }

    public IEnumerator CorutinStart()
    {
        Debug.Log("24");
        float t = 0.0f;
        float rate = (1f / 4) * 1;
        while (t < 1f)
        {
            t += Time.deltaTime * rate;
            transform.position = Vector3.Lerp(PosStart, PosEnd, t);
            yield return null;
        }
    }
}
