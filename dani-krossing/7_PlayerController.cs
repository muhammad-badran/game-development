using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] ObjectBehaviour _objectBehaviour;

    float _playerSpeed = 30f;
    float _inputHorizontal; // -1, 0, or 1 // left - still - right


    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _objectBehaviour.SpawnObject();
    }

    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");

        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _playerSpeed, 0f));
        }
    }
}