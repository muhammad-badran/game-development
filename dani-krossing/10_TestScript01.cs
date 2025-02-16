using UnityEngine;

public class TestScript01 : MonoBehaviour
{
    // underscore in front of collider (_col) because it is a field
    BoxCollider2D _col;

    // Start is called before the first frame update
    void Start()
    {
        _col = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _col.enabled = !_col.enabled;
        }
    }

}