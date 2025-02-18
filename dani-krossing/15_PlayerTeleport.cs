using System.Collections;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    PlayerController _playerController;
    [SerializeField] GameObject _teleportLocation;

    Coroutine _coroutine;

    void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _coroutine = StartCoroutine(TeleportDelay());
        }
        if (Input.GetKeyDown(KeyCode.W)) // Press W to stop all corotuines
        {
            // StopAllCoroutines();
            StopCoroutine(_coroutine);
        }
    }

    IEnumerator TeleportDelay()
    {
        _playerController._disableMovement = true;
        // yield return null;
        yield return new WaitForSeconds(3.5f);
        gameObject.transform.position = _teleportLocation.transform.position;
        yield return null;
        _playerController._disableMovement = false;
    }
}
