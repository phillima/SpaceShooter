﻿using UnityEngine;
using System.Collections;
using Assets.Scripts.arma.municao;

namespace Assets.Scripts.asteroide
{
    public class AsteroidePadrao : Asteroide
    {

        private void Awake() {
            init(50,10,3,5);
        }

        private void Update() {
            movimentacao();
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            Municao municao = collision.GetComponentInParent<Municao>();
            if (municao != null) {
                tomarDano(municao.Dano);
            }
        }
    }
}