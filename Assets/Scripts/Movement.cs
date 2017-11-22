using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour { 

    private Rigidbody _rigidbody;
    public float _speed;
    public float _maxspeed;
    private float _moveHorizontal;
    private float _moveVertical;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Check for keyboard input
        if (Input.anyKey)
        {
            _moveHorizontal = Input.GetAxis("Horizontal");
            _moveVertical = Input.GetAxis("Vertical");
        }
            else //No keyboard input, check for tilt input
        {
            _moveHorizontal =  Input.acceleration.x;
            _moveVertical = Input.acceleration.y;
        }

        //Making a vector of movement
        Vector3 movement = new Vector3(_moveHorizontal, 0, _moveVertical);

        //Applying vector to player
        _rigidbody.AddForce(movement * _speed);

        //Limiting movement speed
        _rigidbody.velocity = Vector3.ClampMagnitude(_rigidbody.velocity, _maxspeed);
    }
}
