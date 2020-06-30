
using UnityEngine;

public class Point : PointBase
{
    [SerializeField]
    public PointBase mainPoint{get; set;}
    
    public bool isConnected => mainPoint;
}
