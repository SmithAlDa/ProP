using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamusB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;

        float angle = Random.Range(0, 2*Mathf.PI);

        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        Rigidbody2D rgbd = GetComponent<Rigidbody2D>();
        rgbd.AddForce(direction*magnitude, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
