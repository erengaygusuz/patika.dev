using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private Rigidbody ballRigidbody;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 150.0f;

    public GameObject gameOverPanel;
    public Text message;

    private void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        ballRigidbody.AddForce(new Vector3(verticalInput, 0.0f, -horizontalInput) * speed);
        Camera.main.transform.position = ballRigidbody.transform.position + new Vector3(-15, 10, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "End")
        {
            Debug.Log("End");
            gameOverPanel.SetActive(true);
            message.text = "You won the game";

            Time.timeScale = 0;
        }

        if (other.tag == "Die")
        {
            Debug.Log("Die");

            gameOverPanel.SetActive(true);
            message.text = "You lose the game";

            Time.timeScale = 0;
        }
    }

    public void PlayAgainBtnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }

    public void ExitBtnClick()
    {
        Application.Quit();
    }
}
