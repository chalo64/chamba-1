using UnityEngine;


public class Enemigo : MonoBehaviour,idanable
{
    public float vida = 10f;

    public void RecibirDano(float vida)
    {
        vida -= vida;

        Debug.Log(vida);

        if (vida <= 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Debug.Log("se arrano");
        Destroy(gameObject);
    }
}