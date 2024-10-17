using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;

    public Text gemText;
    public static int gemCount;

    public SceneLoader scene;

    // Start is called before the first frame update
    void Start()
    {
        gemCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + scoreCount;
        gemText.text = "Gem : " + gemCount + "/10";

        if (gemCount == 10)
        {
            scene.ToWin();
        }
    }

    public void ResetScore()
    {
        gemCount = 10;
        scoreCount = 0;
    }
}
