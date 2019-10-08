using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V20_RandomCharGen
{
    //struct Ability
    //{
    //    public int maxGen;
    //    public string name;


    //}



    class Character
    {
        class Ability
        {
            public int maximum;
            public int currentPoints;
            public int Attribute1Val;
            public int Attribute2Val;
            public int Attribute3Val;
        }
        Ability physical = new Ability();
        Ability social = new Ability();
        Ability mental = new Ability();
        List<int> abilityValuesArray = new List<int>(new int[] { 7, 5, 3 });
        List<Ability> abilitiesArray = new List<Ability>();
        List<Ability> doneAbilitiesArray = new List<Ability>();
        readonly List<Ability> list = new List<Ability>();
        private readonly Random rand = new Random();

        public Character()
        {
            abilitiesArray.Add(physical);
            abilitiesArray.Add(social);
            abilitiesArray.Add(mental);
            GenerateAbilities();
        }



    public static int limit(int value, int min, int max)
    {
        if (value > max) { value = max; }
        if (value < min) { value = min; }
        return value;
    }
    private void GenerateAbilities()
        {


            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(0, abilityValuesArray.Count - 1);
                int index1 = rand.Next(0, abilitiesArray.Count - 1);
                abilitiesArray[index1].currentPoints = abilityValuesArray[index];
                abilitiesArray[index1].maximum = 5;
                list.Add(abilitiesArray[index1]);
                abilitiesArray.RemoveAt(index1);
                abilityValuesArray.RemoveAt(index);

            }

            foreach (Ability ab in list) 
            {
                bool flag = false;
                int curPoints = ab.currentPoints; 
                while (!flag)
                {

                    int r1 = rand.Next(0, ab.maximum);
                    r1 = limit(r1, 0, curPoints);
                    ab.Attribute1Val = ab.Attribute1Val + r1;
                    curPoints = curPoints - r1;

                    int r2 = rand.Next(0, ab.maximum);
                    r2 = limit(r2, 0, curPoints);
                    ab.Attribute2Val = ab.Attribute2Val + r2;
                    curPoints = curPoints - r2;

                    int r3 = rand.Next(0, ab.maximum);
                    r3 = limit(r3, 0, curPoints);
                    ab.Attribute3Val = ab.Attribute3Val + r3;
                    curPoints = curPoints - r3;

                    flag = (curPoints <= 0);

                }


                
            }




        }




    }
}

