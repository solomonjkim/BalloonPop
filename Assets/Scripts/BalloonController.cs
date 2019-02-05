using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float balloonSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float changeInHeight = Time.deltaTime * balloonSpeed;

        Vector3 positionOffset = new Vector3(0, changeInHeight, 0);

        transform.position += positionOffset;
    }
}
