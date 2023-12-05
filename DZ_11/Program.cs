using System;
using System.Reflection;

namespace DZ_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building q = new Building(1, 2, 3, 4);
            Building q_2 = new Building(1, 2, 3, 4);
            Building q_3 = new Building(1, 2, 3, 4);
            Console.WriteLine($"Этажи - {q.Floors}, высота - {q.Height}, квартиры - {q.Apartments}, подъезды - {q.Entrance}");
            FewBuilding fewBuilding = new FewBuilding();
            fewBuilding[0] = q;
            fewBuilding[1] = q_2;
            fewBuilding[2] = q_3;
            Console.WriteLine($"Первое здание - {fewBuilding[0]}");
            Console.WriteLine($"Второе здание - {fewBuilding[0]}");
            Console.WriteLine($"Третье здание - {fewBuilding[0]}");
            Console.ReadKey();

            BankAccount account = new BankAccount(1000, Account.Сберегательный);
            account.DumpToScreen();
            Console.ReadKey();

            MemberInfo typeInfo = typeof(RationalNumbers);
            object[] attributes = typeInfo.GetCustomAttributes(false);
            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfoAttribute att)
                {
                    Console.WriteLine($"{att.Developer}, {att.Date}");
                }
            }
            Console.ReadKey();
            MemberInfo info = typeof(RationalNumbers);
            attributes = typeInfo.GetCustomAttributes(false);
            foreach (Attribute attribute in attributes)
            {
                if (attribute is DeveloperInfoAttribute att)
                {
                    Console.WriteLine($"{att.Developer}, {att.Date}");
                }
            }
            Console.ReadKey();
        }
    }
}
