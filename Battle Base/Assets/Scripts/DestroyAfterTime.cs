using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField]
    float fTimer;

    void Update()
    {
        fTimer -= Time.deltaTime;
        if (fTimer < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
