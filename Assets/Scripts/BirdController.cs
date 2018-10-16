using UnityEngine;

namespace Assets.Scripts
{
    public class BirdController : MonoBehaviour
    {
        private bool isDead = false;         

        public float flapForce = 300;
        private Animator anim;
        private Rigidbody2D rb;

        void Start ()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
        }
	
        void Update () {
            Flap();
        }

        void Flap()
        {
            if (isDead == false)
                if (Input.GetMouseButtonDown(0))
                {
                    anim.SetTrigger("Flap");
                    rb.velocity = Vector2.zero;
                    rb.AddForce(Vector2.up*flapForce);
                }
        }




        void OnCollisionEnter2D(Collision2D other)
        {
            rb.velocity = Vector2.zero;
            isDead = true;
            anim.SetTrigger("Die");
            GameManager.instance.BirdDied();
        }
    }
}
