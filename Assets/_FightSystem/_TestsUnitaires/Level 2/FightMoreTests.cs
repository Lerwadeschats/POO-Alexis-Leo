using _2023_GC_A2_Partiel_POO.Level_2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_GC_A2_Partiel_POO.Tests.Level_2
{
    public class FightMoreTests
    {
        // Tu as probablement remarqué qu'il y a encore beaucoup de code qui n'a pas été testé ...
        // À présent c'est à toi de créer les TU sur le reste et de les implémenter

        // Ce que tu peux ajouter:
        // - Ajouter davantage de sécurité sur les tests apportés -----
        // - un heal ne régénère pas plus que les HP Max -----
        // - si on abaisse les HPMax les HP courant doivent suivre si c'est au dessus de la nouvelle valeur -----
        // - ajouter un equipement qui rend les attaques prioritaires puis l'enlever et voir que l'attaque n'est plus prioritaire etc)
        // - Le support des status (sleep et burn) qui font des effets à la fin du tour et/ou empeche le pkmn d'agir
        // - Gérer la notion de force/faiblesse avec les différentes attaques à disposition (skills.cs)
        // - Cumuler les force/faiblesses en ajoutant un type pour l'équipement qui rendrait plus sensible/résistant à un type

        [Test]
        [TestCase(TYPE.FIRE,TYPE.WATER, 0.8f)]
        [TestCase(TYPE.NORMAL, TYPE.NORMAL, 1 )]
        [TestCase(TYPE.WATER, TYPE.WATER, 1 )]
        [TestCase(TYPE.GRASS, TYPE.WATER, 1.2f)]
        public void TestGetFactor(TYPE attacker, TYPE receiver, float expected)
        {
            float result = TypeResolver.GetFactor(attacker, receiver);
            Assert.AreEqual(result, expected);
        }

        [Test]
        
        public void FightWithSleep()
        {
            Character pikachu = new Character(100, 50, 30, 20, TYPE.NORMAL);
            Character mewtwo = new Character(1000, 50, 0, 200, TYPE.NORMAL);
            Fight f = new Fight(pikachu, mewtwo);
            Punch p = new Punch();
            MagicalGrass g = new MagicalGrass();

            f.ExecuteTurn(g, p);

            Assert.That(mewtwo.CurrentStatus, Is.EqualTo(StatusPotential.SLEEP));
        }

        [Test]

        public void Heal()
        {
            var c = new Character(100, 50, 30, 20, TYPE.NORMAL);
            var punch = new Punch();
            c.ReceiveAttack(punch, null);
            c.ReceiveAttack(punch, null);
            c.Heal();
            Assert.That(c.CurrentHealth, Is.EqualTo(70));
        }

        [Test]

        public void HealWithMaxLife()
        {
            var c = new Character(100, 50, 30, 20, TYPE.NORMAL);
            var punch = new Punch();
            c.ReceiveAttack(punch, null);
            c.Heal();
            c.Heal();
            Assert.That(c.CurrentHealth, Is.EqualTo(100));
        }

        [Test]

        public void DealDamage()
        {
            Character mystherbe = new Character(100, 50, 30, 20, TYPE.GRASS);
            Character aquali = new Character(100, 50, 0, 200, TYPE.WATER);
            Fight f = new Fight(aquali, mystherbe);
            FireBall b = new FireBall();
            MagicalGrass g = new MagicalGrass();
            f.ExecuteTurn(g, b);
            TypeResolver.GetFactor(TYPE b, aquali)
        }



    }

}
