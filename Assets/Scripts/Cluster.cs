using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Cluster : MonoBehaviour
{
    [SerializeField, Range(0.1f, 10f)]
    float minDistance;
    
    [SerializeField]
    ICollection<Point> points;

    // Start is called before the first frame update
    void Start()
    {
        points =  GameObject.FindObjectsOfType<Point>();
        
        foreach(Point p in points)
        {
            Debug.Log(p.Position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
