using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public void OpenToScene(int changeTheScene){
        SceneManager.LoadScene(changeTheScene);
    }
}
