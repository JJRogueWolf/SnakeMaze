using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private Text gameScoreText;

    [SerializeField]
    private Text gameEndScore;

    [SerializeField]
    private GameObject GameEndScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        GameEndScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gameScoreText.text = gameManager.score.ToString();
        gameEndScore.text = gameManager.score.ToString();
    }

    public void retryGame()
    {
        SceneManager.LoadScene(0);
    }
}
