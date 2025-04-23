using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public abstract class Character
{
    private Rigidbody _rigidbody;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;

        public float speed = 5f;

    public void movimento()
    {

            void Update()
            {
                float movementX = Input.GetAxis("Horizontal"); // A/D o frecce sx/dx
                float movementY = Input.GetAxis("Vertical");   // W/S o frecce su/giù

                Vector3 movement = new Vector3(movementX, movementY, 0f);
                //transform.Translate(movement * speed * Time.deltaTime);
            }
    }
    
}
