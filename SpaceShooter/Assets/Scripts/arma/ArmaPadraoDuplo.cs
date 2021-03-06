﻿using UnityEngine;
using System.Collections;

namespace Assets.Scripts.arma
{
    public class ArmaPadraoDuplo : Arma
    {

        private void Awake() {
            init(0.5f);
        }

        public override void atirar() {
            if (Time.time > NextFire) {
                NextFire = fireRate + Time.time;
                Vector3 posUpper = GameObject.FindGameObjectWithTag("UpperShooter").transform.position;
                Vector3 posLower = GameObject.FindGameObjectWithTag("LowerShooter").transform.position;
                Instantiate(municao, posUpper, Quaternion.identity);
                Instantiate(municao, posLower, Quaternion.identity);
                audioSource.PlayOneShot(audioSource.clip);
            }
        }
    }
}