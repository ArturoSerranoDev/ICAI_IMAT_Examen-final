using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 moveDirection;
    public Vector3 MoveDirection
    {
        set => moveDirection = value;
    }

    private void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * 5);
    }

    public void UpdateView()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
       
    }
    
    private void OnTriggerExit(Collider other)
    {
        
    }
}
