using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    [SerializeField] private Enemy[] enemyTypes;  // Array of enemy types
    [SerializeField] private TMP_Text playerNameText, playerHealthText, enemyNameText, enemyHealthText;

    void Start()
    {
        UpdateUI();
    }

    public void DoRound()
    {
        int playerDamage = player.Attack();
        enemy.GetHit(playerDamage);

        if (enemy.health <= 0)
        {
            Debug.Log("Enemy defeated! Spawning new enemy...");
            SpawnNewEnemy();
            return;
        }

        int enemyDamage = enemy.Attack();
        player.GetHit(enemyDamage);

        if (player.health <= 0)
        {
            Debug.Log("Game Over!");
            return;
        }

        UpdateUI();
    }

    
    public void SpawnNewEnemy()
    {
        if (enemyTypes.Length == 0) return; // Make sure there are enemies to spawn

        if (enemy != null) Destroy(enemy.gameObject); // Remove current enemy

        int randomIndex = Random.Range(0, enemyTypes.Length);
        enemy = Instantiate(enemyTypes[randomIndex]); // Spawn new enemy
        enemy.health = Random.Range(50, 100);
        enemy.name = enemyTypes[randomIndex].name;

        UpdateUI();
    }

    private void UpdateUI()
    {
        playerNameText.text = player.CharName;
        enemyNameText.text = enemy.name;
        playerHealthText.text = player.health.ToString();
        enemyHealthText.text = enemy.health.ToString();
    }
}
