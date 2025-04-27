using UnityEngine;

public class PlayerController : MonoBehaviour
{
    InputSystemActions inputSystemActions;
    [SerializeField] Move move;

    void Awake()
    {
        inputSystemActions = new InputSystemActions();
    }

    void Start()
    {
        // bind the move action
        inputSystemActions.Player.Move.performed += _ => move.OnMove();
    }

    void Update()
    {
        // use the input system to update the move vector
        move.UpdateInputVector(inputSystemActions.Player.Move.ReadValue<Vector2>());
    }

    void OnEnable()
    {
        inputSystemActions.Enable();
    }

    void OnDisable()
    {
        inputSystemActions.Disable();
    }
}
