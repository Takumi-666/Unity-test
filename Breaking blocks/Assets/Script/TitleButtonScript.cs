using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonScript : MonoBehaviour
{
    public void OnTitleButtonPressed()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
