using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPoint : PointBase
{
    [SerializeField]
    List<Point> points;
    [SerializeField]
    Color colorArea = Color.yellow;
    [SerializeField, Range(0.1f, 10f)]
    float radiusArea;
    [SerializeField]
    LayerMask detectLayer;
    [SerializeField]
    LineRenderer line;    

    void Start()
    {
        
    }

    void FixedUpdate() 
    {
        Collider[] col = Physics.OverlapSphere(Position, radiusArea, detectLayer);
        foreach(Collider c in col)
        {
            if(col.Length > 0 && !c.GetComponent<Point>().isConnected)
            {
                Point point = c.GetComponent<Point>();
                point.mainPoint = this;
                //Vector3[] positions = {Position, point.Position};
                LineRenderer lineClone = (LineRenderer)Instantiate(line, transform.localPosition, Quaternion.identity, transform);
                lineClone.SetPosition(0, Vector3.zero);
                lineClone.transform.LookAt(point.transform);
                lineClone.SetPosition(1, new Vector3(0, 0, Vector3.Distance(Position, point.Position)));
                lineClone.gameObject.SetActive(true);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = colorArea;
        Gizmos.DrawWireSphere(Position, radiusArea);
    }

}
