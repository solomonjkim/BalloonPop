using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float balloonSpeed;
    public float maxHeight;
    public float initialHeight;

    // Start is called before the first frame update
    void Start()
    {
        initialHeight = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float changeInHeight = Time.deltaTime * balloonSpeed;

        Vector3 positionOffset = new Vector3(0, changeInHeight, 0);

        transform.position += positionOffset;

        if (transform.position.y - initialHeight > maxHeight) {
            Destroy(gameObject);
        }
    }
}
