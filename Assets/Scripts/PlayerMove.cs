using UnityEngine;

//эта строчка гарантирует что наш скрипт не завалится ести на плеере будет отсутствовать компонент Rigidbody
[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    
    public float Speed = 3f; //скорость передвижения
    public float JumpForce = 110f;//сила прыжка
    private bool _isGrounded;//земля
    float rotSpeed = 3f;//скорость поворота
    private Rigidbody _rb;

  //  private Animator _anim;

   // private void Awake()
   // {
   //     _anim = GetComponent<Animator>();
   // }

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
      
        
        JumpLogic();
        MovementLogic();
    }

    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Speed * Time.fixedDeltaTime);

        float rotation = Input.GetAxis("HorizontalRotate") * rotSpeed;
        transform.rotation *= Quaternion.Euler(0f, rotation, 0f);
    }

    private void JumpLogic()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            if (_isGrounded)
            {
                _rb.AddForce(Vector3.up * JumpForce);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
    }

    void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }

    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = value;
        }
    }
}