using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 _offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    
    private void Awake()
    {
        _offset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = target.transform.position + _offset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothTime);
    }
    
}
