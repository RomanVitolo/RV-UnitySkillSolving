using UnityEngine;


public class Bounce : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    
    void OnTriggerEnter(Collider other)
    {
        JumpyJumpy(other);
    }

    void JumpyJumpy(Collider other)
    {
        var getEntity = other.GetComponent<Rigidbody>();
        getEntity.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
