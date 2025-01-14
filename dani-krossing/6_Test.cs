using UnityEngine;

public class Test : MonoBehaviour
{

    private int _playerHealth = 100;
    private int _playerShield = 50;

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
    public int PlayerShield
    {
        get
        {
            return _playerShield;
        }
        set
        {
            _playerShield = value;
        }
    }

    private void Start()
    {
        Debug.Log("You took " + DamageTaken(80) + " in damage!");
    }

    int DamageTaken(int damage)
    {
        int damageTaken;

        // initial code
        if (damage < PlayerShield)
        {
            Debug.Log("Shield not destroyed");
            damageTaken = 0;
        }
        else if (damage == PlayerShield)
        {
            Debug.Log("Shield destroyed");
            damageTaken = 0;
        }
        else
        {
            Debug.Log("Shield not destroyed and damage taken");
            damageTaken = damage - PlayerShield;
        }

        // final code to use compound conditions

        if (damage < PlayerShield && damage == PlayerShield) // || pipe symbol for or
        {
            Debug.Log("Shield not destoryed!");
            damageTaken = 0;
        }

        return damageTaken;
    }

}