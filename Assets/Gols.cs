using UnityEngine;

public class Gol : MonoBehaviour
{
    public int jogadorQueMarca; // GolDir: 1 | GolEsq: 2

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bola"))
            GameManager.instance.Ponto(jogadorQueMarca);
    }
}