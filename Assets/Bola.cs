using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade = 8f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Lancar();
    }

    public void Lancar()
    {
        transform.position = Vector2.zero;
        float dirX = Random.value < 0.5f ? -1f : 1f;
        float dirY = Random.Range(-0.5f, 0.5f);
        rb.linearVelocity = new Vector2(dirX, dirY).normalized * velocidade;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Raquete>() != null)
        {
            float offset = (transform.position.y - col.transform.position.y) / col.collider.bounds.size.y;
            float dirX = rb.linearVelocity.x > 0 ? 1f : -1f;
            rb.linearVelocity = new Vector2(dirX, offset * 2f).normalized * velocidade;
        }
    }
}