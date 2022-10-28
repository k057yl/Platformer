using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] AudioSource m_AudioSource;
    void Awake()
    {
        m_AudioSource.Play();
    }
    public void ToStart()
    {
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        
    }
}
