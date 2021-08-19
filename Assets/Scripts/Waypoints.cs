using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    // ismi points olan bir dizi oluşturduk
    public static Transform[] points;

    void Awake()
    {    
        //elemanı olan tüm waypointleri bu diziye atadık
        points = new Transform[transform.childCount];
        // tek tek waypoint objesinin içindeki elemanları alıyoruz
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
