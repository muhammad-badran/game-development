using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody2D _rb;

    // Although you can show fields in Unity by setting them to public instead of private
    // but it is not recommended. Use SerializeField Instead.
    [SerializeField] private int _playerHealth = 100;
    private float _playerSpeed = 4.6f;
    private bool _isGrounded = true;
    private string _playerName = "Sam";
    private Vector2 _playerPosition = new Vector2(-5f, 0f);

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _rb.transform.position = _playerPosition;
        _rb.gravityScale = 0;
    }
}