using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 5f;
    
    private float _horizontalMovement;
    
    void Start()
    {
        
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(_horizontalMovement * speed, rb.linearVelocity.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        _horizontalMovement = context.ReadValue<Vector2>().x;
    }
}
