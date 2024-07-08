using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SceneAsset gameScene;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameScene.name);
    }
}
