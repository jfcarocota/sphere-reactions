using UnityEngine;


public class PointBase: MonoBehaviour
{

    private Rigidbody rb;
     [SerializeField]
     float moveSpeed;
    
    public PointBase(){}

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public Vector3 Position => transform.position;

    private void Update()
    {
        //Debug.Log(Mathf.Cos(Time.deltaTime));
        //transform.Translate(Vector3.up * Mathf.Sin(Time.time)  * moveSpeed * Time.deltaTime);
    }
}