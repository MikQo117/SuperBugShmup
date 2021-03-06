﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Use this for initialization
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    protected virtual void Fire()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}