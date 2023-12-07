using UnityEngine;

public class DamageSpikes : MonoBehaviour
{
    public int damageAmount = 110000;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerStats PlayerStats = collision.gameObject.GetComponent<PlayerStats>();

            if (PlayerStats != null)
            {
                PlayerStats.DecreaseHealth(damageAmount);
            }
        }
    }
}