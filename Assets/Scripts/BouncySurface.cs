using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Vector2 Normal = collision.GetContact(0).normal;
            ball.AddForce(-Normal * this.bounceStrength);
        }
    }
}
