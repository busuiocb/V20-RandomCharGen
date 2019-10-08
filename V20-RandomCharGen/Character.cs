using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V20_RandomCharGen
{

    class Character
    {
        class AbilityGroup
        {
            public int maximum;
            public int currentPoints;
            public int Attribute1Val;
            public int Attribute2Val;
            public int Attribute3Val;
        }
        readonly AbilityGroup physical = new AbilityGroup();
        readonly AbilityGroup social = new AbilityGroup();
        readonly AbilityGroup mental = new AbilityGroup();
        readonly List<int> abilityGroupValuesArray = new List<int>(new int[] { 7, 5, 3 });
        readonly List<AbilityGroup> abilityGroupArray = new List<AbilityGroup>();
        readonly List<AbilityGroup> list = new List<AbilityGroup>();
        private readonly Random rand = new Random();

        public Character()
        {
            abilityGroupArray.Add(physical);
            abilityGroupArray.Add(social);
            abilityGroupArray.Add(mental);
            GenerateAbilities();
        }



    public static int Limit(int value, int min, int max)
    {
        if (value > max) { value = max; }
        if (value < min) { value = min; }
        return value;
    }
    private void GenerateAbilities()
        {


            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(0, abilityGroupValuesArray.Count - 1);
                int index1 = rand.Next(0, abilityGroupArray.Count - 1);
                abilityGroupArray[index1].currentPoints = abilityGroupValuesArray[index];
                abilityGroupArray[index1].maximum = 5;
                list.Add(abilityGroupArray[index1]);
                abilityGroupArray.RemoveAt(index1);
                abilityGroupValuesArray.RemoveAt(index);

            }

            foreach (AbilityGroup ab in list) 
            {
                bool flag = false;
                int curPoints = ab.currentPoints; 
                while (!flag)
                {

                    int r1 = rand.Next(0, ab.maximum);
                    r1 = Limit(r1, 0, curPoints);
                    ab.Attribute1Val += r1;
                    curPoints -= r1;

                    int r2 = rand.Next(0, ab.maximum);
                    r2 = Limit(r2, 0, curPoints);
                    ab.Attribute2Val += r2;
                    curPoints -= r2;

                    int r3 = rand.Next(0, ab.maximum);
                    r3 = Limit(r3, 0, curPoints);
                    ab.Attribute3Val += r3;
                    curPoints -= r3;

                    flag = (curPoints <= 0);

                }
                ab.Attribute1Val++;
                ab.Attribute2Val++;
                ab.Attribute3Val++;



            }




        }




    }
}

