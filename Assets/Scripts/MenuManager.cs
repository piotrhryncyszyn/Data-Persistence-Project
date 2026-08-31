using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public string playerName;
    public static MenuManager Instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void grabPlayerName(string name)
    {
        playerName = name;
    }

}
