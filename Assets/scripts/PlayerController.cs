using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] float speed;
    [SerializeField] LayerMask enemyLayer;
    private void Update()
    {
        Vector3 movementVector = Vector3.zero;

        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = 0;
        movementVector.z = Input.GetAxisRaw("Vertical");

        characterController.Move(movementVector * Time.deltaTime * speed);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, 100f))
        {
            Vector3 position = hitInfo.point;
            position.y = 0;
            transform.LookAt(position);
        }


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit enemyInfo;
            Ray rayo = new Ray(transform.position, transform.forward);
            Debug.DrawRay(rayo.origin, rayo.direction * 10, Color.pink, 10f);
            if (Physics.Raycast(rayo.origin, rayo.direction, out enemyInfo, 100f, enemyLayer))
            {
                Debug.Log(enemyInfo.transform.gameObject.name);
            }
            else
            {
                Debug.Log("Se te hace asi Jaitovich");
            }
        }
    }
}