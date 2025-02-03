using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class StaminaBar : MonoBehaviour
    {
        public float stamina;
        public float maxStamina;
        public Image staminaBar;
        private float nextActionTime = 0.0f;
        public float period = 0.1f;
        private void Start()
        {
            maxStamina = stamina;
        }

        private void Update()
        {
            staminaBar.fillAmount = Mathf.Clamp(stamina / maxStamina, 0, 1);

            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                stamina++;
            }
        }
    }
}