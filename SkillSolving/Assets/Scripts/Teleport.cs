using UnityEngine;


public class Teleport : MonoBehaviour
{
    [SerializeField] Transform teleportTarget;
    [SerializeField] GameObject player;
    [SerializeField] Light areaLight;
    [SerializeField] Light mainWorldLight;

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))  //TODO Use Interface and TryGetComponent instead of tag
            TeleportPlayer();
    }

    void TeleportPlayer() => player.transform.position = teleportTarget.position;
}
