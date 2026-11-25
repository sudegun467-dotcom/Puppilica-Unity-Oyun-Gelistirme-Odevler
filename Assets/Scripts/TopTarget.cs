using UnityEngine;

public class TopTarget : MonoBehaviour
{
    [SerializeField] private Transform castle;
    [SerializeField] private float hitForce = 5f;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void RollTowards(Vector3 hitPoint)
    {
        Vector3 direction = castle.position - transform.position;

        direction.y = 0f;
        direction.Normalize();

        rb.AddForceAtPosition(
            direction * hitForce,
            hitPoint,
            ForceMode.Impulse
        );
    }
}
