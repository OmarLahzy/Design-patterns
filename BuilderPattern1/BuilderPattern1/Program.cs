using System;

namespace BuilderPattern1
{
    class Program
    {

        class EnemyDeirector
        {
            private EnemyBuilder _Enemybuilder;

            public EnemyDeirector(EnemyBuilder Enemy)
            {
                this._Enemybuilder = Enemy;
            }
            public void EnemyCreator()
            {
                _Enemybuilder.SetEnemyType();
                _Enemybuilder.SetWeponeType();
                _Enemybuilder.SetHitpoint();
                _Enemybuilder.SetMagicpoint();
            }
            public void GetEnemy()
            {
                EnemyProduct enemy =  _Enemybuilder.GetEnemy();

                Console.WriteLine("EnemyType : {0}\nEnemyWepone : {1}\nHitpoints : {2}\nMagicPoints : {3}"
                ,enemy.EnemyType,enemy.WeponeType,enemy.Hitpoint,enemy.Magicpoint);
            }


        }


        abstract class EnemyBuilder
        {
            public abstract void SetEnemyType();
            public abstract void SetWeponeType();
            public abstract void SetHitpoint();
            public abstract void SetMagicpoint();
            public abstract EnemyProduct GetEnemy();


        }
        class EnemyA : EnemyBuilder
        {
            EnemyProduct enemy = new EnemyProduct();

            public override EnemyProduct GetEnemy()
            {
                return enemy;
            }

            public override void SetEnemyType()
            {
                enemy.EnemyType = "SpellCaster";
            }

            public override void SetHitpoint()
            {
                enemy.Hitpoint = 200;

            }

            public override void SetMagicpoint()
            {
                enemy.Magicpoint = 300;

            }

            public override void SetWeponeType()
            {
                enemy.WeponeType = "staff";
            }
        }
        class EnemyB : EnemyBuilder
        {
            EnemyProduct enemy = new EnemyProduct();

            public override EnemyProduct GetEnemy()
            {
                return enemy;
            }

            public override void SetEnemyType()
            {
                enemy.EnemyType = "Tanker";
            }

            public override void SetHitpoint()
            {
                enemy.Hitpoint = 100;

            }

            public override void SetMagicpoint()
            {
                enemy.Magicpoint = 200;

            }

            public override void SetWeponeType()
            {
                enemy.WeponeType = "Shield";
            }
        }

        class EnemyProduct
        {
            public String EnemyType;
            public String WeponeType;
            public int Hitpoint;
            public int Magicpoint;

        }
        static void Main(string[] args)
        {
            EnemyDeirector EnemyA = new EnemyDeirector(new EnemyA());
            EnemyA.EnemyCreator();
            EnemyA.GetEnemy();

            Console.WriteLine("----------------------------------------------------------");

            EnemyDeirector EnemyB = new EnemyDeirector(new EnemyB());
            EnemyB.EnemyCreator();
            EnemyB.GetEnemy();
        }
    }
}
