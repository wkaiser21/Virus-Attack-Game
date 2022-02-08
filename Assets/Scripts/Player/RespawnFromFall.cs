using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnFromFall : MonoBehaviour
{
    public float minHeight;

    void Update()
    {
        if (transform.position.y < minHeight)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
