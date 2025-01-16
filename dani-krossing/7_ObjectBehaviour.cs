using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    bool _gameover = false;
    [SerializeField] int _score = 0;

    public void SpawnObject()
    {
        Instantiate(prefab, new Vector3(Random.Range(-8, 8), 8f, 0f), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !_gameover) // Player tag
        {
            _score += 1;
            SpawnObject();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Ground") // Ground tag
        {
            _gameover = true;
            Debug.Log("GAME OVER! Your score is " + _score + ".");
        }
    }
}
