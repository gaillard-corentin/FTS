using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{

    
    private Transform target;

    [Header("Attributes")]

    public float range = 15f;
    public float firerate = 1f;
    private float fireCountdown = 0f;


    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";

    public Transform PartToRotate;
    public float turnspeed = 5f;

    public GameObject Bulletprefab;
    public Transform firePoint;


    void Start()

    {
        //Vector3 oridir = PartToRotate.position;
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }

    }

    void Update()
    {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            Quaternion lookrotation = Quaternion.LookRotation(dir);
            Vector3 rotation = (Quaternion.Lerp(PartToRotate.rotation, lookrotation, Time.deltaTime * turnspeed)).eulerAngles;
            PartToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
            //PartToRotate.rotation = Quaternion.Lerp(transform.rotation, targetrotation, Time.deltaTime *3);

            //return;
        }
        else
        {


            //Vector3 pos = PartToRotate.position;
            Vector3 oridir = -PartToRotate.position;
            //Debug.Log(oridir.ToString());

            Quaternion lookrotation2 = Quaternion.LookRotation(oridir);/*
        //Vector3 rotation2 = (Quaternion.Lerp(PartToRotate.rotation, lookrotation2, Time.deltaTime * turnspeed)).eulerAngles;
        //PartToRotate.rotation = Quaternion.Euler(0f, rotation2.y, 0f);*/
            PartToRotate.rotation = Quaternion.Lerp(PartToRotate.rotation, lookrotation2, Time.deltaTime * turnspeed);
            return;

        }
            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / firerate;

            }

            fireCountdown -= Time.deltaTime;
        

    }
    void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(Bulletprefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
