using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    private void Update()
    {
        Movement();
    }
    private void FixedUpdate()
    {
        PhysicsMovement();
    }
    public void Movement()
    {
        if (Input.GetKey(KeyCode.Z) || (Input.GetKey(KeyCode.UpArrow)))
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }
    public void PhysicsMovement()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _Rigidbody.AddForce(_direction * this.Speed);
        }
    }
}
