using UnityEngine;

public class SingleTon<T> : MonoBehaviour where T : SingleTon<T>
{
    private static T _instance;
    private static T Instance => _instance;
    [SerializeField] private bool isDontDestroyOnload;

    private void Awake()
    {
        if ( _instance == null )
        {
            _instance = (T) this;
        }
    }
}
