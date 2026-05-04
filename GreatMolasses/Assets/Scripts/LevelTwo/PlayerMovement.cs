using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Input stores a value between -1 and 1
        //GetAxisRaw() takes exactly -1 or +1
        //GetAxis() would take values in between -1 to +1 (useful for acceleration)
        //Getting the axis is mapped to A/D, left/right arrow and joystick left/right
        float input = Input.GetAxisRaw("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
