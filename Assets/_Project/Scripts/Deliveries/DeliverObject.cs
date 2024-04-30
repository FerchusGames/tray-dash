using System;
using UnityEngine;

public class DeliverObject : MonoBehaviour
{
    public GameObject _particleSystem;

    private GameObject _playerObject;

    private void Start()
    {
        _playerObject = GameObject.FindWithTag("Respawn");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            GameManager.Instance.AddScore(1);
            Destroy(other.gameObject);
            GameObject particleSystem = Instantiate(_particleSystem, other.transform.position, other.transform.rotation);
            particleSystem.transform.SetParent(_playerObject.transform);
        }
    }
}

