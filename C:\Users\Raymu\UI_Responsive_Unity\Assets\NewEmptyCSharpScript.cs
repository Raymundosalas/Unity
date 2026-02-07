using UnityEngine;

public class AbrirEnlaces : MonoBehaviour
{
    public void AbrirGoogle()
    {
        Application.OpenURL("https://www.google.com");
    }

    public void AbrirYouTube()
    {
        Application.OpenURL("https://www.youtube.com");
    }

    public void AbrirUnity()
    {
        Application.OpenURL("https://unity.com");
    }
}
