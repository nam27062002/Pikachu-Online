using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance = null;
    public static T Instance => instance;

    protected void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Debug.LogWarning($"An instance of {typeof(T).Name} already exists. Deleting duplicate instance.");
            Destroy(gameObject);
        }
    }
    protected void OnEnable()
    {
        
    }

    protected void OnDisable()
    {
        
    }
}
