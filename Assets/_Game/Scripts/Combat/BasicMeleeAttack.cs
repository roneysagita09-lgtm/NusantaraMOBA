using UnityEngine;
using NusantaraMOBA.Core;

namespace NusantaraMOBA.Combat
{
    public sealed class BasicMeleeAttack : MonoBehaviour
    {
        [SerializeField, Min(0.1f)] private float attackRange = 1.8f;
        [SerializeField, Min(0.1f)] private float damage = 50f;
        [SerializeField, Min(0.05f)] private float attackCooldown = 0.8f;
        [SerializeField] private LayerMask targetLayers = ~0;
        [SerializeField] private Transform attackOrigin;
        [SerializeField] private KeyCode attackKey = KeyCode.Space;

        private float nextAttackTime;

        private void Update()
        {
            if (Input.GetKeyDown(attackKey)) TryAttack();
        }

        public bool TryAttack()
        {
            if (Time.time < nextAttackTime) return false;
            nextAttackTime = Time.time + attackCooldown;
            Vector3 origin = attackOrigin != null
                ? attackOrigin.position
                : transform.position + Vector3.up;
            Collider[] hits = Physics.OverlapSphere(
                origin, attackRange, targetLayers, QueryTriggerInteraction.Ignore);

            IDamageable closest = null;
            float closestDistance = float.MaxValue;
            foreach (Collider hit in hits)
            {
                if (hit.transform == transform || hit.transform.IsChildOf(transform))
                    continue;
                IDamageable candidate = hit.GetComponentInParent<IDamageable>();
                if (candidate == null || !candidate.IsAlive) continue;
                float distance = (hit.ClosestPoint(origin) - origin).sqrMagnitude;
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = candidate;
                }
            }

            if (closest == null) return false;
            closest.TakeDamage(damage);
            return true;
        }

        private void OnDrawGizmosSelected()
        {
            Vector3 origin = attackOrigin != null
                ? attackOrigin.position
                : transform.position + Vector3.up;
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(origin, attackRange);
        }
    }
}
