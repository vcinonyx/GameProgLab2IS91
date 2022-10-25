using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] string sceneName;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
