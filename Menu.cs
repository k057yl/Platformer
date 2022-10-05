using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void ToScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ToMenu()
    {
            PlayerPrefs.Save();
            SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToMenu();
        }
    }
}
