using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;
    private int WaypointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];

    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        
        Quaternion targetrotation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetrotation, Time.deltaTime * 5);

        if (Vector3.Distance(transform.position,target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (WaypointIndex >=Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        WaypointIndex++;
        target = Waypoints.points[WaypointIndex];
    }

}
