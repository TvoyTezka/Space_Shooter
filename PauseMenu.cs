using UnityEngine;

public class PauseButton : MonoBehaviour
{
    private bool isPaused = false;
    private Game backgroundScript; // ������ �� ������ ������� Background
    private EnemyMove enemyMoveScript;
    private Bullet bulletScript;

    private void Start()
    {
        // �������� ��������� Game �� ������� Background
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
            Time.timeScale = 0; // ������������� ����� � ����
            enemyMoveScript.speed = 0f;
            bulletScript.speed = 0f;
            if (backgroundScript != null)
                backgroundScript.isMoving = false; // ������������� �������� ������� Background
        }
        else
        {
            Time.timeScale = 1; // ������������ ����� � ����
            enemyMoveScript.speed = 3f;
            bulletScript.speed = 5f;
            if (backgroundScript != null)
                backgroundScript.isMoving = true; // ������������ �������� ������� Background
        }
    }
}
