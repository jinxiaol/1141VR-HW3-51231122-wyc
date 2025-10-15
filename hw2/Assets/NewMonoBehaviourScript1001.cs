using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    private PlayerControls controls;
    private Vector2 moveInput;
    private void Awake()
    {
        controls = new PlayerControls();
        controls.Gameplay.Enable();
    }
    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }
    void Update()
    {
        moveInput = controls.Gameplay.Move.ReadValue<Vector2>();
        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
