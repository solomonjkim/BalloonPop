using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public float balloonSpeed;
    public float maxHeight;
    public float initialHeight;
    private bool isTargeted;
    public GameObject popEffect;
    public int points = 1;

    public delegate void OnPop(int pts);

    public static event OnPop onBalloonPop;

    void PopBalloon()
    {
        GameObject effectObject = Instantiate(popEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(effectObject, 3);
        onBalloonPop?.Invoke(points);
    }

    public void SetGazedAt(bool gazedAt)
    {
        isTargeted = gazedAt;
    }

    public void Fire()
    {
        if (isTargeted)
        {
            PopBalloon();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        initialHeight = transform.position.y;
        SetGazedAt(false);
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
