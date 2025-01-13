using UnityEngine;

public class Test : MonoBehaviour
{

    private int _playerHealth = 100;
    
    // Create a Property to grab or change the data from fields without referring to the field . why?
    // 1 - you can add additional code to set or get methods
    // 2 - restrict other scripts from chaning a property
    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }
        set
        {
            _playerHealth = value;
        }
    }

    public string DisplayHealthPercentage
    {
        get
        {
            string health = _playerHealth.ToString() + "%";
            return health;
        }
    }

    // auto property
    // it creates the field, get and set methods internally in a shorter way
    public int PlayerHealthAuto { get; set;}

    private void Start()
    {
        // chaning the property (using keyword 'value') instead of using the field
        Debug.Log(DisplayHealthPercentage);
    }
}

// you need to know 3 things when it comes to classes:
// 1. fields
// 2. properties
// 3. methods
