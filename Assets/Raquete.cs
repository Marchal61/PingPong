using UnityEngine;

public class Raquete : MonoBehaviour
{
    public float velocidade = 8f;
    public float limite = 4f;
    public KeyCode cima = KeyCode.W;
    public KeyCode baixo = KeyCode.S;

    void Update()
    {
        float mov = 0f;
        if (Input.GetKey(cima)) mov = 1f;
        if (Input.GetKey(baixo)) mov = -1f;

        float y = transform.position.y + mov * velocidade * Time.deltaTime;
        y = Mathf.Clamp(y, -limite, limite);
        transform.position = new Vector3(transform.position.x, y, 0f);
    }
}