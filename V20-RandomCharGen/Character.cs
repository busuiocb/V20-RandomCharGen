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
        readonly AttributeGroup physical = new AttributeGroup();
        readonly AttributeGroup social = new AttributeGroup();
        readonly AttributeGroup mental = new AttributeGroup();
        readonly List<int> AttributeGroupValuesArray = new List<int>(new int[] { 7, 5, 3 });
        readonly List<AttributeGroup> AttributeGroupArray = new List<AttributeGroup>();
        readonly List<AttributeGroup> list = new List<AttributeGroup>();
        private readonly Random rand = new Random();

        public Character()
        {
            AttributeGroupArray.Add(physical);
            AttributeGroupArray.Add(social);
            AttributeGroupArray.Add(mental);
            
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
                int index = rand.Next(0, AttributeGroupValuesArray.Count);
                int index1 = rand.Next(0, AttributeGroupArray.Count);
                AttributeGroupArray[index1].currentPoints = AttributeGroupValuesArray[index];
                AttributeGroupArray[index1].maximum = 4;
                list.Add(AttributeGroupArray[index1]);
                AttributeGroupArray.RemoveAt(index1);
                AttributeGroupValuesArray.RemoveAt(index);

            }

            //Generate a random value for each attribute based on the priority assigned previously
            foreach (AttributeGroup att in list) 
            {
                bool flag = false;
                int curPoints = att.currentPoints;
 
                while (!flag)
                {

                    int r1 = rand.Next(0, att.maximum); 
                    r1 = Limit(r1, 0, curPoints);
                    att.Attribute1Val =  Limit(r1 + att.Attribute1Val, 0, att.maximum);
                    curPoints -= r1;

                    int r2 = rand.Next(0, att.maximum);
                    r2 = Limit(r2, 0, curPoints);
                    att.Attribute2Val = Limit(r2 + att.Attribute2Val, 0, att.maximum); ;
                    curPoints -= r2;
                    
                    int r3 = rand.Next(0, att.maximum);
                    r3 = Limit(r3, 0, curPoints);
                    att.Attribute3Val = Limit(r3 + att.Attribute3Val, 0, att.maximum);
                    curPoints -= r3;
                    flag = (curPoints <= 0);



                }
                //Each attribute starts with 1 level by default
                att.Attribute1Val++;
                att.Attribute2Val++;
                att.Attribute3Val++;



            }

            return list;


        }




    }
}

