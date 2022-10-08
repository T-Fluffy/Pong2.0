using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float Speed = 10.0f;
    protected Rigidbody2D _Rigidbody;
    private void Awake()
    {
        _Rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        _Rigidbody.position = new Vector2(_Rigidbody.position.x, 0.0f);
        _Rigidbody.velocity = Vector2.zero;
    }
}
