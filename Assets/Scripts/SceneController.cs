using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneController : MonoBehaviour
{
    [SerializeField]
    private Button playBt;

    private void Start()
    {
        playBt.onClick.AddListener(()=>GoToGameScene());
    }
    public void GoToGameScene()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }
}
