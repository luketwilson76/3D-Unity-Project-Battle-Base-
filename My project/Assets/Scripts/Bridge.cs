using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentChildren<Animator>();
    }

   private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            animator.SetTrigger("Lower Bridge");
        }
    }
