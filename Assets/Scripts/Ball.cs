using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Speed = 200.0f;
    private Rigidbody2D _RigidBody;
    private void Awake()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }
    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-0.1f, -0.5f) : Random.Range(0.5f, 0.1f);
        Vector2 direction = new Vector2(x, y);
        _RigidBody.AddForce(direction * this.Speed);
    }
    public void AddForce(Vector2 force)
    {
        _RigidBody.AddForce(force);
    }
    public void ResetPosition()
    {
        _RigidBody.position = Vector3.zero;
        _RigidBody.velocity = Vector3.zero;
    }
}
