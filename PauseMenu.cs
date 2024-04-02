using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool isPaused = false;
    private Game backgroundScript; // Ссылка на скрипт объекта Background
    private EnemyMove enemyMoveScript;
    private Bullet bulletScript;

    private void Start()
    {
        // Получаем компонент Game из объекта Background
        backgroundScript = GameObject.FindObjectOfType<Game>();
    }
    private void Update()
    {
        enemyMoveScript = GameObject.FindObjectOfType<EnemyMove>();
        bulletScript = GameObject.FindObjectOfType<Bullet>();
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // Останавливаем время в игре
            enemyMoveScript.speed = 0f;
            bulletScript.speed = 0f;
            if (backgroundScript != null)
                backgroundScript.isMoving = false; // Останавливаем движение объекта Background
        }
        else
        {
            Time.timeScale = 1; // Возобновляем время в игре
            enemyMoveScript.speed = 3f;
            bulletScript.speed = 5f;
            if (backgroundScript != null)
                backgroundScript.isMoving = true; // Возобновляем движение объекта Background
        }
    }
}
