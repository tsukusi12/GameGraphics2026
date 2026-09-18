using UnityEngine;
using UnityEngine.InputSystem;
 
public class PlayerController : MonoBehaviour
{
  public string playerName = "Player";
  public int hp = 100;
  public float moveSpeed = 5f;
  private Vector2 moveInput;


  void Start()
  {
     Debug.Log(playerName + " 시작. 체력 " + hp);
  }
  void OnMove(InputValue value)
  {

    moveInput = value.Get<Vector2>();
  }
 
  void Update()
  {
    transform.Translate(Vector3.right * moveInput.x * moveSpeed * Time.deltaTime);
  }
}
