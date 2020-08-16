using System;

namespace M4_L44_Encapsulation_In_Class_activity
{
    public class WeightConverter
    {
        private string _w;
        public string W { get => _w; set => _w = ConvertToPound(value); }
        private string ConvertToPound(string s)
        {
            float val;
            const float KG_to_LB = 2.20462f;
            s = s.ToLower();
            string[] sa = s.Split(' ');
            if (sa[1] == "kg")
            {
                val = float.Parse(sa[0]);
                val = val * KG_to_LB;
                sa[0] = val.ToString();
                sa[1] = "lb";
            }
            return string.Join(" ", sa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeightConverter input = new WeightConverter();
            Console.WriteLine("Please enter any weight (in kg or lb): ");
            input.W = Console.ReadLine();
            Console.WriteLine("Your entered weight is: {0}", input.W);
            Console.Read();
        }
    }
}
