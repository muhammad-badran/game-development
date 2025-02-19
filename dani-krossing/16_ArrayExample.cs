using UnityEngine;


public class ArrayEample : MonoBehaviour
{
    // Example 01
    int _number = 12;
    int[] _numberArray = new int[4];

    // Example 02
    string[] _names = { "Unity", "Game", "Engine" };

    // Example 03
    [SerializeField] GameObject[] _players;

    void Start()
    {
        _numberArray[0] = 10;


        _players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _players = GameObject.FindGameObjectsWithTag("Enemy");
        }

    }
}
