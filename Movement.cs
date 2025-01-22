using UnityEngine;
using UnityEngine.InputSystem;


public class Movement : MonoBehaviour
{

    [SerializeField] private float speed;
    private PlayerInput input;
    Vector2 moveFromInputs;

    void Start()
    {
        
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");



        Vector3 move = new Vector3(x, 0, y);
        transform.Translate(move * speed * Time.deltaTime);
        Input.GetMouseButtonDown(0);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
        }

        Input.GetKey(KeyCode.Space);
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Jump");
        }

    }

    public void Move(InputAction.CallbackContext callback)
    {

        moveFromInputs = callback.ReadValue<Vector2>();
        Vector3 move = new Vector3(moveFromInputs.x, 0, moveFromInputs.y);
        transform.Translate(move * speed * Time.deltaTime);

    }


}
