using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class NewBehaviourScript : MonoBehaviour
    {
        public float health;
        public float maxHealth;
        public Image healthBar;
        private void Start()
        {
            maxHealth = health;
        }

        private void Update()
        {
            healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
        }
    }
}