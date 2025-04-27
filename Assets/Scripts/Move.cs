using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    Vector2 inputVector;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        OnMove();
    }


    public void OnMove()
    {
        // convert the directional vector into a movement vector3
        Vector3 moveDirection = new Vector3(inputVector.x, 0, inputVector.y);

        // move the object
        rb.linearVelocity = moveDirection * moveSpeed;
    }

    public void UpdateInputVector(Vector2 input)
    {
        inputVector = input;
    }
}