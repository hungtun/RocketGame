using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    float movementFactor ;
    [SerializeField] float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(period <= Mathf.Epsilon) return;
        float cycles = Time.time / period; // so chu ky sau 1 khoang tgian
        const float tau = Mathf.PI * 2; // 2pi
        movementFactor = (Mathf.Sin(cycles * tau) + 1) / 2; // gia tri tu 0 den 1
        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPosition + offset;
    }
}
