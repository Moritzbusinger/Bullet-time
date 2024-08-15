
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;

    [SerializeField] private float move_speed;
    [SerializeField] private float fly_speed;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        body.velocity = new Vector3(fly_speed, Input.GetAxis("Vertical")* move_speed);
    }
}
