using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Virus))]
public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    private int wavepointIndex = 0;
    private Virus enemy;

    void Start()
    {
        target = Waypoints.points[0];
        enemy = GetComponent<Virus>();
    }
    
    void Update()
    {
        //waypointe doğru ilerler
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * enemy.speed * Time.deltaTime,Space.World);

        //waypointer vardığında GetNextWaypointi çağırır
        if (Vector3.Distance(transform.position,target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
        enemy.speed = enemy.startSpeed;
    }

    void GetNextWaypoint()
    {
        // bundan bir sonraki waypointi alır ve target olarak belirler

        if (wavepointIndex >= Waypoints.points.Length - 1 )
        {
            EndPath();
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPath ()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
