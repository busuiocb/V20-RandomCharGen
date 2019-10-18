using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V20_RandomCharGen
{

    class Character
    {
        public class AttributeGroup
        {
            public int maximum;
            public int currentPoints;
            public int Attribute1Val;
            public int Attribute2Val;
            public int Attribute3Val;
        }
        public class AbilityGroup
        {
            public int maximum;
            public int currentPoints;
            public int Ability1Val;
            public int Ability2Val;
            public int Ability3Val;
            public int Ability4Val;
            public int Ability5Val;
            public int Ability6Val;
            public int Ability7Val;
            public int Ability8Val;
            public int Ability9Val;
            public int Ability10Val;

        }
        //Attribute Variables
        readonly AttributeGroup physical = new AttributeGroup();
        readonly AttributeGroup social = new AttributeGroup();
        readonly AttributeGroup mental = new AttributeGroup();
        readonly List<int> AttributeGroupValuesArray = new List<int>(new int[] { 7, 5, 3 });
        readonly List<AttributeGroup> AttributeGroupArray = new List<AttributeGroup>();
        readonly List<AttributeGroup> AttributeList = new List<AttributeGroup>();
        private readonly Random randAttribute = new Random();

        //Aility Variables
        readonly AbilityGroup talents = new AbilityGroup();
        readonly AbilityGroup skills = new AbilityGroup();
        readonly AbilityGroup knowledges = new AbilityGroup();
        readonly List<int> AbilityGroupValuesArray = new List<int>(new int[] { 13, 9, 5 });
        readonly List<AbilityGroup> AbilityGroupArray = new List<AbilityGroup>();
        readonly List<AbilityGroup> AbilityList = new List<AbilityGroup>();
        private readonly Random randAbility = new Random();



        public Character()
        {
            AttributeGroupArray.Add(physical);
            AttributeGroupArray.Add(social);
            AttributeGroupArray.Add(mental);

            AbilityGroupArray.Add(talents);
            AbilityGroupArray.Add(skills);
            AbilityGroupArray.Add(knowledges);

        }


        //Method to limit values
        public static int Limit(int value, int min, int max)
        {
            if (value > max) { value = max; }
            if (value < min) { value = min; }
            return value;
        }

        //Generate random attributes
        public List<AttributeGroup> GenerateAttributes()
        {

            //Assign priority order to each attribute group
            for (int i = 0; i < 3; i++)
            {
                int index = randAttribute.Next(0, AttributeGroupValuesArray.Count);
                int index1 = randAttribute.Next(0, AttributeGroupArray.Count);
                AttributeGroupArray[index1].currentPoints = AttributeGroupValuesArray[index];
                AttributeGroupArray[index1].maximum = 4;
                AttributeList.Add(AttributeGroupArray[index1]);
                AttributeGroupArray.RemoveAt(index1);
                AttributeGroupValuesArray.RemoveAt(index);

            }

            //Generate a random value for each attribute based on the priority assigned previously
            foreach (AttributeGroup att in AttributeList) 
            {
                bool flag = false;
                int curPoints = att.currentPoints;
                Random random = new Random();
                while (!flag)
                {
                    int r = random.Next(1, 4);

                    switch (r)
                    {
                        case 1:
                    int r1 = randAttribute.Next(0, att.maximum);
                    r1 = Limit(r1, 0, curPoints);
                    att.Attribute1Val = Limit(r1 + att.Attribute1Val, 0, att.maximum);
                    curPoints -= r1;
                            break;
                        case 2:
                    int r2 = randAttribute.Next(0, att.maximum);
                    r2 = Limit(r2, 0, curPoints);
                    att.Attribute2Val = Limit(r2 + att.Attribute2Val, 0, att.maximum); ;
                    curPoints -= r2;
                            break;

                        case 3:
                    int r3 = randAttribute.Next(0, att.maximum);
                    r3 = Limit(r3, 0, curPoints);
                    att.Attribute3Val = Limit(r3 + att.Attribute3Val, 0, att.maximum);
                    curPoints -= r3;
                            break;
                    }
                    flag = (curPoints <= 0);



                }
                //Each attribute starts with 1 level by default
                att.Attribute1Val++;
                att.Attribute2Val++;
                att.Attribute3Val++;



            }

            return AttributeList;


        }
        //Generate random abilities
        public List<AbilityGroup> GenerateAbilities()
        {

            //Assign priority order to each ability group
            for (int i = 0; i < 3; i++)
            {
                int index = randAbility.Next(0, AbilityGroupValuesArray.Count);
                int index1 = randAbility.Next(0, AbilityGroupValuesArray.Count);
                AbilityGroupArray[index1].currentPoints = AbilityGroupValuesArray[index];
                AbilityGroupArray[index1].maximum = 3;
                AbilityList.Add(AbilityGroupArray[index1]);
                AbilityGroupArray.RemoveAt(index1);
                AbilityGroupValuesArray.RemoveAt(index);

            }

            //Generate a random value for each ability based on the priority assigned previously
            foreach (AbilityGroup ab in AbilityList)
            {
                bool flag = false;
                int curPoints = ab.currentPoints;
                Random random = new Random();
                while (!flag)
                {
                    int r = random.Next(1, 11);

                    switch (r)
                    {

                    case 1:
                    int r1 = randAttribute.Next(0, ab.maximum);
                    r1 = Limit(r1, 0, curPoints);
                    ab.Ability1Val = Limit(r1 + ab.Ability1Val, 0, ab.maximum);
                    curPoints -= r1;
                    break;

                    case 2:
                    int r2 = randAttribute.Next(0, ab.maximum);
                    r2 = Limit(r2, 0, curPoints);
                    ab.Ability2Val = Limit(r2 + ab.Ability2Val, 0, ab.maximum); ;
                    curPoints -= r2;
                    break;

                    case 3:
                    int r3 = randAttribute.Next(0, ab.maximum);
                    r3 = Limit(r3, 0, curPoints);
                    ab.Ability3Val = Limit(r3 + ab.Ability3Val, 0, ab.maximum);
                    curPoints -= r3;
                    break;

                    case 4:
                    int r4 = randAttribute.Next(0, ab.maximum);
                    r4 = Limit(r4, 0, curPoints);
                    ab.Ability4Val = Limit(r4 + ab.Ability4Val, 0, ab.maximum);
                    curPoints -= r4;
                    break;

                    case 5:
                    int r5 = randAttribute.Next(0, ab.maximum);
                    r5 = Limit(r5, 0, curPoints);
                    ab.Ability5Val = Limit(r5 + ab.Ability5Val, 0, ab.maximum);
                    curPoints -= r5;
                    break;

                    case 6:
                    int r6 = randAttribute.Next(0, ab.maximum);
                    r6 = Limit(r6, 0, curPoints);
                    ab.Ability6Val = Limit(r6 + ab.Ability6Val, 0, ab.maximum);
                    curPoints -= r6;
                    break;

                    case 7:
                    int r7 = randAttribute.Next(0, ab.maximum);
                    r7 = Limit(r7, 0, curPoints);
                    ab.Ability7Val = Limit(r7 + ab.Ability7Val, 0, ab.maximum);
                    curPoints -= r7;
                    break;

                    case 8:
                    int r8 = randAttribute.Next(0, ab.maximum);
                    r8 = Limit(r8, 0, curPoints);
                    ab.Ability8Val = Limit(r8 + ab.Ability8Val, 0, ab.maximum);
                    curPoints -= r8;
                    break;

                    case 9:
                    int r9 = randAttribute.Next(0, ab.maximum);
                    r9 = Limit(r9, 0, curPoints);
                    ab.Ability9Val = Limit(r9 + ab.Ability9Val, 0, ab.maximum);
                    curPoints -= r9;
                    break;

                    case 10:
                    int r10 = randAttribute.Next(0, ab.maximum);
                    r10 = Limit(r10, 0, curPoints);
                    ab.Ability10Val = Limit(r10 + ab.Ability10Val, 0, ab.maximum);
                    curPoints -= r10;
                    break;
                }
                    flag = (curPoints <= 0);



                }

            }

            return AbilityList;


        }



    }
}

