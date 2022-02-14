using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTowards : MonoBehaviour
{
    [SerializeField]
    Transform transTowards;

    [SerializeField]
    float fSpeed;

    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3MeTowardsTarget = transTowards.position - transform.position;
        rigid.velocity += v3MeTowardsTarget.normalized * fSpeed * Time.deltaTime;
    }
}
