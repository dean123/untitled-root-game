using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 10f;

    //private CharacterController characterController;
    //private Vector3 moveDirection = Vector3.zero;
    private Rigidbody rigidb;

    private void Start()
    {
        //characterController = GetComponent<CharacterController>();
        rigidb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log(vertical);

        rigidb.AddForce(transform.right * Mathf.Clamp(vertical, -1f, 1f) * speed);

    }
}
