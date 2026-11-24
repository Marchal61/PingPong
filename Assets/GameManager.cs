using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMP_Text textoEsq;
    public TMP_Text textoDir;
    public Bola bola;
    int pontosEsq, pontosDir;

    void Awake() { instance = this; }

    public void Ponto(int jogador)
    {
        if (jogador == 1) pontosEsq++;
        else pontosDir++;

        textoEsq.text = pontosEsq.ToString();
        textoDir.text = pontosDir.ToString();
        bola.Lancar();
    }
}