using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public MeshRenderer mesh;
    public Animator animator1;
    public Animator animator2;
    int tally = 0;
    void Start()

    {
        animator1 = GetComponent<Animator>();
        animator2 = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            tally = tally + 1;
        }
        if (Input.GetKeyDown("e") && tally % 2 == 1)
        {
            mesh.enabled = true;
            animator1.SetTrigger("Raise Mirror");
        }
        if (Input.GetKeyDown("e") && tally % 2 == 0)
        {
            animator2.SetTrigger("Lower Mirror");
            mesh.enabled = false;
        }
    }
}