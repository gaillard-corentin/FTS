﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    private Transform target;

    public float speed = 70f;
    public GameObject ImpactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if (target ==null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distancethisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distancethisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distancethisFrame, Space.World);

    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(ImpactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        //Destroy(target.gameObject);
        Destroy(gameObject);

    }
}
