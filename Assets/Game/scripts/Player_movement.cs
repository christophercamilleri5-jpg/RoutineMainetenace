using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))] //so this are used for character movement this is requird for new updated issue

public class Player_movement : MonoBehaviour
{

    [SerializeField] private float speed = 5f;  //Serializedfield is there so that we can see it from the inprector and unity 

    private CharacterController controller;
    
    private Vector2 input; //vector2 is for x and y and vector3 is zxy
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = new Vector3(input.x, 0, input.y);
        controller.Move( movement * Time.deltaTime);
    }

    //recive by da playerinput componet (aka from the player componet list) when WASD is pressed.
    private void OnMove(InputValue value)
    {
        input = value.Get<Vector2>() * speed;
    }
}
