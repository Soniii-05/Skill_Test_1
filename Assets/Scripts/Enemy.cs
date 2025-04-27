using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : Character
{
    public float speed;

    private SpriteRenderer spriteRenderer;
    private Vector2 moveDirection = Vector2.right;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(moveDirection * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("EnemyWall"))
        {
            moveDirection = -moveDirection;
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}


