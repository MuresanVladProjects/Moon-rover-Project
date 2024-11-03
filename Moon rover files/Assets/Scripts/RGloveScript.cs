using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGloveScript : MonoBehaviour
{
    private Animator animator;
    public float close = 0f;
    public float point = 0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            close = 0.99f;
            point = 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            close = 0.1f;
            point = 0.99f;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            close = 0;
            point = 0;
        }

        animator.SetFloat("RClose", close);
        animator.SetFloat("RPoint", point);
    }
}
