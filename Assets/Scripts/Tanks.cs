using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tanks : MonoBehaviour
{
    Vector2 tankMovementSpeed;
    public float tankSpeed =1f;
    public InputAction move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(tankSpeed * tankMovementSpeed.y * Time.deltaTime * Vector3.forward);
    }

    public void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Fire");
    }

    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log("Move");
        tankMovementSpeed = context.ReadValue<Vector2>();
       //transform.Translate( 10 * context.ReadValue<Vector2>().y * Time.deltaTime * Vector3.forward);
    }
}
