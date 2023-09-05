using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShtorEnd : MonoBehaviour
{
    public GameObject size1;
    public GameObject size2;
    public float i;

    void Update()
    {
        if (i < 14f & SceneManager.GetActiveScene().buildIndex != 1)
        {
            size1.transform.localScale = new Vector3(150f, i, 1f);
            size2.transform.localScale = new Vector3(150f, i, 1f);
            i += 0.1f;
        }

        else if (i > 1f & SceneManager.GetActiveScene().buildIndex == 1)
        {
            size1.transform.localScale = new Vector3(150f, i, 1f);
            size2.transform.localScale = new Vector3(150f, i, 1f);
            i -= 0.1f;
        }
    }
}
