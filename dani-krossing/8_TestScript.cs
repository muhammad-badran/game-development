using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] GameObject _item;

    // Start is called before the first frame update
    void Strart()
    {
        // use each type of loops one at a time and comment out the others
        int itemCount = 5;
        // 1- while loop
        while (itemCount > 0)
        {
            SpawnItem();
            itemCount--;
        }

        // 2 - do-while loop
        int itemCount2 = 0;
        do
        {
            SpawnItem();
            itemCount--;
        }
        while (itemCount2 > 0);

        // 3 - for loop
        for (int i = 5; i > 0; i--)
        {
            SpawnItem();
        }
    }
    void SpawnItem()
    {
        Instantiate(_item, new Vector2(Random.Range(6.5f, -6.5f), Random.Range(3.5f, -3.5f)), Quaternion.identity);
    }
}
