using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;

    void Start() {
        rb.useGravity = false;
        }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.useGravity = true;
            Debug.Log("Collided with Player");
        }
    }
}
