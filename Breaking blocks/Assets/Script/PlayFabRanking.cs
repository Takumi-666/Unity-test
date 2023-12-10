using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class PlayFabRanking : MonoBehaviour
{
    void Start()
    {
        GetLeaderboard();
    }

    public void GetLeaderboard()
    {
        PlayFabClientAPI.GetLeaderboard(new GetLeaderboardRequest
        {
            StatisticName = "testgame"
        }, result =>
        {
            foreach (var item in result.Leaderboard)
            {
                string displayName = item.DisplayName ?? "NoName";
                Debug.Log($"{item.Position + 1}位: {displayName} スコア {item.StatValue}");
            }
        }, error =>
        {
            Debug.Log("ランキングデータ取得失敗: " + error.GenerateErrorReport());
        });
    }
}
