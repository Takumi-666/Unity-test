using UnityEngine;
using UnityEngine.SceneManagement;

public class RankingButtonScript : MonoBehaviour
{
    public void OnRankingButtonPressed()
    {
        SceneManager.LoadScene("RankingScene");
    }
}
