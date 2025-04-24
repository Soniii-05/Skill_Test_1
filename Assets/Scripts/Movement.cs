using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : Character
{
    public float speed;
    public float jumpForce;
    public bool isGrounded = false;

    private Rigidbody2D _rigidbody;
    private Animator _animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(movementX, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
        

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector2.up * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.collider.CompareTag("DeathWall"))
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    
}
