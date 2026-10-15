using UnityEngine;

public class Puerta : MonoBehaviour, iinteracttuable
{
    public void interact()
    {
        Debug.Log("Usas: " + gameObject.name);
    }
}