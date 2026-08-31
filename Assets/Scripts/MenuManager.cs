using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartNew()
    {
        Debug.Log("button clicked");
        SceneManager.LoadScene(1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
