using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(RawImage))]
public class MoveObs : MonoBehaviour
{
    [SerializeField] Vector3 dir;
    private float speed = 0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    private void Update()
    {
        rb.AddForce(dir * speed * Time.deltaTime);
    }
}
