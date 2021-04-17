using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;
    public int facing = 1;


    private void Start()
    {
        GameObject.Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * facing * Time.deltaTime);
    }

    public void SetDirection(int dir)
    {
        facing = dir;
    }
}


