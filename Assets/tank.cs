


using UnityEngine;
using UnityEngine.InputSystem;



public class Tank : MonoBehaviour
{ [SerializeField] private float maxSpeed = 10;
    [SerializeField] private float rotationSpeed = 25;
    
    private Transform localTransform;

    private float rotateAxis;
    
    // Start is called before the first frame update
    void Start()
    {
        localTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        /*
        localTransform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        localTransform.Translate(Input.GetAxis("Vertical") * Vector3.forward * maxSpeed * Time.deltaTime);
        */
        
        localTransform.Rotate(Vector3.up, rotateAxis * rotationSpeed * Time.deltaTime);
        
        
    }

    public void HandleRotate(InputAction.CallbackContext inputContext)
    {
        rotateAxis = inputContext.ReadValue<float>();
        Debug.Log("Rotate  = " + rotateAxis);
    }
}


public class tank : MonoBehaviour
{
    private PlayerInput playerInput;
    private InputAction moveAction;

    [SerializeField] private float speed = 5;

    // Start is called before the first frame update
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
    }

    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;
    }
}
