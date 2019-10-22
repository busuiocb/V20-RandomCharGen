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
        public class DisciplineGroup
        {
            public int maximum;
            public int currentPoints;
            public int Discipline1Val;
            public int Discipline2Val;
            public int Discipline3Val;

        }
        public class BackgroundGroup
        {
            public int maximum;
            public int currentPoints;
            public int Background1Val;
            public int Background2Val;
            public int Background3Val;
            public int Background4Val;
            public int Background5Val;
            public int Background6Val;
            public int Background7Val;
            public int Background8Val;
            public int Background9Val;
            public int Background10Val;
            public int Background11Val;
            public int Background12Val;
            public int Background13Val;

        }
        public class VirtueGroup
        {
            public int maximum;
            public int currentPoints;
            public int Virtue1Val;
            public int Virtue2Val;
            public int Virtue3Val;
        }
        //Attribute Variables
        readonly AttributeGroup physical = new AttributeGroup();
        readonly AttributeGroup social = new AttributeGroup();
        readonly AttributeGroup mental = new AttributeGroup();
        readonly List<int> AttributeGroupValuesArray = new List<int>(new int[] { 7, 5, 3 });
        readonly List<AttributeGroup> AttributeGroupArray = new List<AttributeGroup>();
        readonly List<AttributeGroup> AttributeList = new List<AttributeGroup>();
        private readonly Random randNumber = new Random();

        //Ability Variables
        readonly AbilityGroup talents = new AbilityGroup();
        readonly AbilityGroup skills = new AbilityGroup();
        readonly AbilityGroup knowledges = new AbilityGroup();
        readonly List<int> AbilityGroupValuesArray = new List<int>(new int[] { 13, 9, 5 });
        readonly List<AbilityGroup> AbilityGroupArray = new List<AbilityGroup>();
        readonly List<AbilityGroup> AbilityList = new List<AbilityGroup>();
     

        //Discipline Variables
        readonly DisciplineGroup clanDisciplines = new DisciplineGroup();
      

        //Backgrounds Variables
        readonly BackgroundGroup backgrounds = new BackgroundGroup();
    

        //Virtues Variables
        readonly VirtueGroup virtues = new VirtueGroup();
      

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
                int index = randNumber.Next(0, AttributeGroupValuesArray.Count);
                int index1 = randNumber.Next(0, AttributeGroupArray.Count);
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
                while (!flag)
                {
                    int r = randNumber.Next(0, 4);

                    switch (r)
                    {
                        case 1:
                    int r1 = randNumber.Next(0, att.maximum);
                    r1 = Limit(r1, 0, curPoints);
                    att.Attribute1Val = Limit(r1 + att.Attribute1Val, 0, att.maximum);
                    curPoints -= r1;
                            break;
                        case 2:
                    int r2 = randNumber.Next(0, att.maximum);
                    r2 = Limit(r2, 0, curPoints);
                    att.Attribute2Val = Limit(r2 + att.Attribute2Val, 0, att.maximum); 
                    curPoints -= r2;
                            break;

                        case 3:
                    int r3 = randNumber.Next(0, att.maximum);
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
                int index = randNumber.Next(0, AbilityGroupValuesArray.Count);
                int index1 = randNumber.Next(0, AbilityGroupValuesArray.Count);
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
                while (!flag)
                {
                    int r = randNumber.Next(0, 11);

                    switch (r)
                    {

                    case 1:
                    int r1 = randNumber.Next(0, ab.maximum);
                    r1 = Limit(r1, 0, curPoints);
                    ab.Ability1Val = Limit(r1 + ab.Ability1Val, 0, ab.maximum);
                    curPoints -= r1;
                    break;

                    case 2:
                    int r2 = randNumber.Next(0, ab.maximum);
                    r2 = Limit(r2, 0, curPoints);
                    ab.Ability2Val = Limit(r2 + ab.Ability2Val, 0, ab.maximum);
                    curPoints -= r2;
                    break;

                    case 3:
                    int r3 = randNumber.Next(0, ab.maximum);
                    r3 = Limit(r3, 0, curPoints);
                    ab.Ability3Val = Limit(r3 + ab.Ability3Val, 0, ab.maximum);
                    curPoints -= r3;
                    break;

                    case 4:
                    int r4 = randNumber.Next(0, ab.maximum);
                    r4 = Limit(r4, 0, curPoints);
                    ab.Ability4Val = Limit(r4 + ab.Ability4Val, 0, ab.maximum);
                    curPoints -= r4;
                    break;

                    case 5:
                    int r5 = randNumber.Next(0, ab.maximum);
                    r5 = Limit(r5, 0, curPoints);
                    ab.Ability5Val = Limit(r5 + ab.Ability5Val, 0, ab.maximum);
                    curPoints -= r5;
                    break;

                    case 6:
                    int r6 = randNumber.Next(0, ab.maximum);
                    r6 = Limit(r6, 0, curPoints);
                    ab.Ability6Val = Limit(r6 + ab.Ability6Val, 0, ab.maximum);
                    curPoints -= r6;
                    break;

                    case 7:
                    int r7 = randNumber.Next(0, ab.maximum);
                    r7 = Limit(r7, 0, curPoints);
                    ab.Ability7Val = Limit(r7 + ab.Ability7Val, 0, ab.maximum);
                    curPoints -= r7;
                    break;

                    case 8:
                    int r8 = randNumber.Next(0, ab.maximum);
                    r8 = Limit(r8, 0, curPoints);
                    ab.Ability8Val = Limit(r8 + ab.Ability8Val, 0, ab.maximum);
                    curPoints -= r8;
                    break;

                    case 9:
                    int r9 = randNumber.Next(0, ab.maximum);
                    r9 = Limit(r9, 0, curPoints);
                    ab.Ability9Val = Limit(r9 + ab.Ability9Val, 0, ab.maximum);
                    curPoints -= r9;
                    break;

                    case 10:
                    int r10 = randNumber.Next(0, ab.maximum);
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

        //Generate random Disciplines
        public DisciplineGroup GenerateDisciplines()
        {
            clanDisciplines.currentPoints = 3;
            clanDisciplines.maximum = 3;
            bool flag = false;
            int curPoints = clanDisciplines.currentPoints;
            while (!flag)
            {
                int r = randNumber.Next(1, 4);
                int remainder;
                switch (r)
                {
                    case 1:
                        int r1 = randNumber.Next(0, clanDisciplines.maximum);
                        r1 = Limit(r1, 0, curPoints);
                        remainder = 0;
                        if (r1 + clanDisciplines.Discipline1Val > clanDisciplines.maximum)
                        {
                            remainder = (r1 + clanDisciplines.Discipline1Val) - clanDisciplines.maximum;
                        }
                        clanDisciplines.Discipline1Val = Limit(r1 + clanDisciplines.Discipline1Val, 0, clanDisciplines.maximum);
                        curPoints = (curPoints - r1) + remainder;
                        
                        break;
                    case 2:
                        int r2 = randNumber.Next(0, clanDisciplines.maximum);
                        r2 = Limit(r2, 0, curPoints);
                        remainder = 0;
                        if (r2 + clanDisciplines.Discipline2Val > clanDisciplines.maximum)
                        {
                            remainder = (r2 + clanDisciplines.Discipline2Val) - clanDisciplines.maximum;
                        }
                        clanDisciplines.Discipline2Val = Limit(r2 + clanDisciplines.Discipline2Val, 0, clanDisciplines.maximum);
                        curPoints = (curPoints - r2) + remainder;
                        
                        break;

                    case 3:
                        int r3 = randNumber.Next(0, clanDisciplines.maximum);
                        r3 = Limit(r3, 0, curPoints);
                        remainder = 0;
                        if (r3 + clanDisciplines.Discipline3Val > clanDisciplines.maximum)
                        {
                            remainder = (r3 + clanDisciplines.Discipline3Val) - clanDisciplines.maximum;
                        }
                        clanDisciplines.Discipline3Val = Limit(r3 + clanDisciplines.Discipline3Val, 0, clanDisciplines.maximum);
                        curPoints = (curPoints - r3) + remainder;
                        
                        break;
                }
                flag = (curPoints <= 0);
            }
                return clanDisciplines;
        }

        //Generate random Backgrounds
        public BackgroundGroup GenerateBackgrounds()
        {
            backgrounds.currentPoints = 5;
            backgrounds.maximum = 5;
            bool flag = false;
            int curPoints = backgrounds.currentPoints;
            while (!flag)
            {
                int r = randNumber.Next(0, 14);

                switch (r)
                {
                    case 1:
                        int r1 = randNumber.Next(0, backgrounds.maximum);
                        r1 = Limit(r1, 0, curPoints);
                        backgrounds.Background1Val = Limit(r1 + backgrounds.Background1Val, 0, backgrounds.maximum);
                        curPoints -= r1;
                        break;

                    case 2:
                        int r2 = randNumber.Next(0, backgrounds.maximum);
                        r2 = Limit(r2, 0, curPoints);
                        backgrounds.Background2Val = Limit(r2 + backgrounds.Background2Val, 0, backgrounds.maximum);
                        curPoints -= r2;
                        break;

                    case 3:
                        int r3 = randNumber.Next(0, clanDisciplines.maximum);
                        r3 = Limit(r3, 0, curPoints);
                        backgrounds.Background3Val = Limit(r3 + backgrounds.Background3Val, 0, backgrounds.maximum);
                        curPoints -= r3;
                        break;

                    case 4:
                        int r4 = randNumber.Next(0, clanDisciplines.maximum);
                        r4 = Limit(r4, 0, curPoints);
                        backgrounds.Background4Val = Limit(r4 + backgrounds.Background4Val, 0, backgrounds.maximum);
                        curPoints -= r4;
                        break;

                    case 5:
                        int r5 = randNumber.Next(0, clanDisciplines.maximum);
                        r5 = Limit(r5, 0, curPoints);
                        backgrounds.Background5Val = Limit(r5 + backgrounds.Background5Val, 0, backgrounds.maximum);
                        curPoints -= r5;
                        break;

                    case 6:
                        int r6 = randNumber.Next(0, clanDisciplines.maximum);
                        r6 = Limit(r6, 0, curPoints);
                        backgrounds.Background6Val = Limit(r6 + backgrounds.Background6Val, 0, backgrounds.maximum);
                        curPoints -= r6;
                        break;

                    case 7:
                        int r7 = randNumber.Next(0, clanDisciplines.maximum);
                        r7 = Limit(r7, 0, curPoints);
                        backgrounds.Background7Val = Limit(r7 + backgrounds.Background7Val, 0, backgrounds.maximum);
                        curPoints -= r7;
                        break;

                    case 8:
                        int r8 = randNumber.Next(0, clanDisciplines.maximum);
                        r8 = Limit(r8, 0, curPoints);
                        backgrounds.Background8Val = Limit(r8 + backgrounds.Background8Val, 0, backgrounds.maximum);
                        curPoints -= r8;
                        break;

                    case 9:
                        int r9 = randNumber.Next(0, clanDisciplines.maximum);
                        r9 = Limit(r9, 0, curPoints);
                        backgrounds.Background9Val = Limit(r9 + backgrounds.Background9Val, 0, backgrounds.maximum);
                        curPoints -= r9;
                        break;

                    case 10:
                        int r10 = randNumber.Next(0, clanDisciplines.maximum);
                        r10 = Limit(r10, 0, curPoints);
                        backgrounds.Background10Val = Limit(r10 + backgrounds.Background10Val, 0, backgrounds.maximum);
                        curPoints -= r10;
                        break;

                    case 11:
                        int r11 = randNumber.Next(0, clanDisciplines.maximum);
                        r11 = Limit(r11, 0, curPoints);
                        backgrounds.Background11Val = Limit(r11 + backgrounds.Background11Val, 0, backgrounds.maximum);
                        curPoints -= r11;
                        break;

                    case 12:
                        int r12 = randNumber.Next(0, clanDisciplines.maximum);
                        r12 = Limit(r12, 0, curPoints);
                        backgrounds.Background12Val = Limit(r12 + backgrounds.Background12Val, 0, backgrounds.maximum);
                        curPoints -= r12;
                        break;

                    case 13:
                        int r13 = randNumber.Next(0, clanDisciplines.maximum);
                        r13 = Limit(r13, 0, curPoints);
                        backgrounds.Background13Val = Limit(r13 + backgrounds.Background13Val, 0, backgrounds.maximum);
                        curPoints -= r13;
                        break;


                }
                flag = (curPoints <= 0);
            }
            return backgrounds;
        }
        //Generate random Virtues
        public VirtueGroup GenerateVirtues()
        {
            virtues.currentPoints = 7;
            virtues.maximum = 4;
            bool flag = false;
            int curPoints = virtues.currentPoints;
            while (!flag)
            {
                int r = randNumber.Next(1, 4);
                int remainder;
                switch (r)
                {
                    case 1:
                        int r1 = randNumber.Next(0, virtues.maximum);
                        r1 = Limit(r1, 0, curPoints);
                        remainder = 0;
                        if (r1 + virtues.Virtue1Val > virtues.maximum)
                        {
                            remainder = (r1 + virtues.Virtue1Val) - virtues.maximum;
                        }
                        virtues.Virtue1Val = Limit(r1 + virtues.Virtue1Val, 0, virtues.maximum);
                        curPoints = (curPoints - r1) + remainder;
                        
                        break;
                    case 2:
                        int r2 = randNumber.Next(0, virtues.maximum);
                        r2 = Limit(r2, 0, curPoints);
                        remainder = 0;
                        if (r2 + virtues.Virtue2Val > virtues.maximum)
                        {
                            remainder = (r2 + virtues.Virtue2Val) - virtues.maximum;
                        }
                        virtues.Virtue2Val = Limit(r2 + virtues.Virtue2Val, 0, virtues.maximum);
                        curPoints = (curPoints - r2) + remainder;
                        
                        break;

                    case 3:
                        int r3 = randNumber.Next(0, virtues.maximum);
                        r3 = Limit(r3, 0, curPoints);
                        remainder = 0;
                        if (r3 + virtues.Virtue3Val > virtues.maximum)
                        {
                            remainder = (r3 + virtues.Virtue3Val) - virtues.maximum;
                        }
                        virtues.Virtue3Val = Limit(r3 + virtues.Virtue3Val, 0, virtues.maximum);
                        curPoints = (curPoints - r3) + remainder;
                        
                        break;
                }
                flag = (curPoints <= 0);
            }

            //Each virtue starts with 1 level by default
            virtues.Virtue1Val++;
            virtues.Virtue2Val++;
            virtues.Virtue3Val++;
            return virtues;
        }


    }
}

