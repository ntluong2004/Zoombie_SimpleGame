using UnityEngine;

public class GunBullet : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 25f;
    [SerializeField] private float TimeDestroy = 0.5f;

    void Start()
    {
        Destroy(gameObject, TimeDestroy);
    }

    void Update()
    {
        MoveBullet();
    }

    void MoveBullet() 
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

    }

}
