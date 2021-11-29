using UnityEngine;

public class Életszerzés : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Health>().AddHealth(healthValue);
        gameObject.SetActive(false);
    }
}
