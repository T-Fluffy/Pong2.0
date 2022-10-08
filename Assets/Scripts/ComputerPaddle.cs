using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        PhysicsMovement();
    }
    public void PhysicsMovement()
    {
        if (this.ball.velocity.x > 0.0f)
        {
            if (this.ball.position.y > this.transform.position.y)
            {
                _Rigidbody.AddForce(Vector2.up * this.Speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                _Rigidbody.AddForce(Vector2.down * this.Speed);
            }
        }
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                _Rigidbody.AddForce(Vector2.down * this.Speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                _Rigidbody.AddForce(Vector2.up * this.Speed);
            }
        }
    }
}
