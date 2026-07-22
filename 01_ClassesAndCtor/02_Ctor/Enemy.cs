using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

#region test_default
//Enemy zombie = new Enemy();
//Console.WriteLine(zombie.Health);
//Console.ReadLine();
#endregion

#region Test_para_ctor

//Enemy zombie = new Enemy(" giant zombie", 300);
//Console.WriteLine(zombie.EnemyName);
//Console.WriteLine(zombie.Health);

#endregion

#region test_copy_ctor

//Enemy zombie1 = new Enemy("giant zombie", 110);
//Enemy zom = new Enemy(zombie1);
//Console.WriteLine(zom.EnemyName);
//Console.WriteLine(zom.Health);
//Console.WriteLine("it was easy man!");

#endregion

#region test_private_ctor

//Counter c2 = new Counter();
//Counter.currenCount = 50;
//Counter.IncrementCount();
//Console.WriteLine(Counter.currenCount);

#endregion

namespace OOP._01_ClassesAndCtor._02_Ctor
{
    internal class Enemy
    {
        static int staticCounter = 0;
        static int instanceCounter = 0;

        public int Id { get; set; }
        public string EnemyName { get; set; }
        public double Health { get; set; }

        static Enemy()
        {
            staticCounter++;
            Console.WriteLine($"static ctor is called :: {staticCounter}");
        }

        public Enemy()
        {
            instanceCounter++;
            Console.WriteLine($"instance ctor is called :: {instanceCounter}");
        }

        #region default ctor

        //public Enemy()
        //{
        //    Console.WriteLine("New Enemy is created.");
        //    Health = 90;
        //}

        #endregion

        #region paramtized ctor

        //public Enemy(string enemyName, double health)
        //{
        //    Console.WriteLine("new enemy was created from paramatized ctor");
        //    EnemyName = enemyName;
        //    Health = health;
        //}

        #endregion

        #region copy_ctor

        //public Enemy(string enemyName, double health)
        //{
        //    Console.WriteLine("new enemy was created from param ctor");
        //    EnemyName = enemyName;
        //    Health = health;
        //}

        //public Enemy(Enemy enemy)
        //{
        //    Console.WriteLine("hello from copy ctor");
        //    Health = enemy.Health;
        //    EnemyName = enemy.EnemyName;
        //}

        #endregion

        #region counterclass for private ctor

        //public class Counter
        //{
        //    public static int currenCount;

        //    private Counter()
        //    {
        //    }

        //    public static int IncrementCount()
        //    {
        //        return currenCount++;
        //    }
        //}

        #endregion
    }
}