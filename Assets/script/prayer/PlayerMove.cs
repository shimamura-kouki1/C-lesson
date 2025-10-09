using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]private float _moveSpeed;//移動スピード
    [SerializeField] private float _junpPower;
    private bool _isJunp = false;

    private Transform _tr;
    private Rigidbody _rb;
    private Vector3 _moveInput;
    private PlayerInput _inputAction;
    private InputAction _move;

    private Vector2 _Horizontal;
    private Vector2 _Vertical;

    private Vector3 _latesPos;

    


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _inputAction = GetComponent<PlayerInput>();
        _tr = GetComponent<Transform>();

        GetComponent<PlayerInput>().neverAutoSwitchControlSchemes = false;
        _move = _inputAction.actions["Move"];
    }

    // Update is called once per frame
    void Update()
    {
        _Horizontal = _move.ReadValue<Vector2>();
        if (_inputAction.actions["Move"].IsPressed())
        {
            _rb.velocity = new Vector3(_Horizontal.x, 0f,_Horizontal.y) * _moveSpeed;
        }

        Vector3 diff = _tr.position - _latesPos;
        _latesPos = _tr.position;

        diff.y = 0f;
        if (diff.magnitude > 0.01f)
        {
            _tr.rotation = Quaternion.LookRotation(diff);
        }

        if (_inputAction.actions["Jump"].WasPressedThisFrame()&& !_isJunp)
        {
            _rb.velocity = new Vector2(0, _junpPower);
            _isJunp = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            _isJunp = false;
        }
    }
}

//public event Action<Vector2> OnMove;タツキが使っていたやつ

//Vector2 moveValue = _moveAction.ReadValue<Vector2>();
//var move = new Vector3(moveValue.x, 0f, moveValue.y) * _moveSpeed * Time.deltaTime;
//transform.Translate(move);


//Vector3 move = transform.right * _moveInput.x + transform.forward * _moveInput.y;// 入力方向をワールド空間に変換
//_controller.Move(move * speed * Time.deltaTime);//　移動を反映