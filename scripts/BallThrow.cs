using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using UnityEngine;


public class BallThrow : MonoBehaviour
{
    private Vector3 _startingPosition;
    public float launchForce = 10f;

    /// Start is called before the first frame update.
    public void Start()
    {
        _startingPosition = transform.position;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "basketball_court:ground 1" || collision.gameObject.name == "basketball_court:court")
        {
            transform.position = _startingPosition;
        }
    }
}

