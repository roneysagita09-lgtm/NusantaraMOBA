using UnityEngine;

namespace NusantaraMOBA.Heroes
{
    [RequireComponent(typeof(CharacterController))]
    public sealed class MOBAHeroController : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField, Min(0f)] private float moveSpeed = 5f;
        [SerializeField, Min(0f)] private float turnSpeed = 720f;
        [SerializeField] private float gravity = -20f;

        [Header("Camera")]
        [SerializeField] private Camera followCamera;
        [SerializeField] private Vector3 cameraOffset = new Vector3(0f, 8f, -7f);
        [SerializeField, Min(0f)] private float cameraSmooth = 10f;
        [SerializeField] private bool cameraLooksAtPlayer = true;

        private CharacterController characterController;
        private float verticalVelocity;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();
            if (followCamera == null) followCamera = Camera.main;
        }

        private void Update() => MovePlayer();

        private void LateUpdate()
        {
            if (followCamera == null) return;
            Vector3 desired = transform.position + cameraOffset;
            followCamera.transform.position = Vector3.Lerp(
                followCamera.transform.position, desired,
                1f - Mathf.Exp(-cameraSmooth * Time.deltaTime));
            if (cameraLooksAtPlayer)
                followCamera.transform.LookAt(transform.position + Vector3.up * 0.8f);
        }

        private void MovePlayer()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            Vector3 input = Vector3.ClampMagnitude(new Vector3(x, 0f, z), 1f);

            if (input.sqrMagnitude > 0.001f)
            {
                Quaternion target = Quaternion.LookRotation(input, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(
                    transform.rotation, target, turnSpeed * Time.deltaTime);
            }

            if (characterController.isGrounded && verticalVelocity < 0f)
                verticalVelocity = -2f;
            verticalVelocity += gravity * Time.deltaTime;
            Vector3 velocity = input * moveSpeed;
            velocity.y = verticalVelocity;
            characterController.Move(velocity * Time.deltaTime);
        }
    }
}
