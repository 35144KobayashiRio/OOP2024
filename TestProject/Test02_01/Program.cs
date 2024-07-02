using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Test02 {

    class Person {
        public string Name { get; set; }  //名前
        public int Age { get; set; }      //年齢
        public int Height { get; set; }   //身長
        public int Weight { get; set; }   //体重
    }

    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> {
                    12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48
                };

            var persons = new List<Person> {
                new Person{Name = "峰博史",Age = 38, Height=170,Weight=68},
                new Person{Name = "片桐鉄也",Age = 29, Height=173,Weight=74},
                new Person{Name = "沖田宏",Age = 28, Height=168,Weight=59},
                new Person{Name = "池中裕次",Age = 21, Height=184,Weight=82},
                new Person{Name = "片山新之助",Age = 35, Height=176,Weight=65},
            };
            #region テスト用ドライバ
            Console.WriteLine("問題１：平均値を表示");
            Exercise01(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題２：奇数の最小値を表示");
            Exercise02(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題３：偶数のみを昇順に並べて表示");
            Exercise03(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題４：0以上30未満の数字のみを表示");
            Exercise04(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題５：最高年齢を表示");
            Exercise05(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題６：年齢20代だけの平均身長を表示");
            Exercise06(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題７：身長170cm以上の「名前と年齢と体重」を全員表示");
            Exercise07(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題８：名前の漢字４文字の人を全て表示");
            Exercise08(persons);
            Console.WriteLine("\n-----");
            #endregion
        }

        //---------------------------------------
        // 以下の問題に書かれている内容を満たすようにプログラムを作成せよ。
        // 必要であればラムダ式とLINQを使用すること
        //---------------------------------------

        //問題１　平均値を表示
        private static void Exercise01(List<int> numbers) {
            var average = numbers.Average(x => x);
            Console.WriteLine(average);

        }

        //問題２　奇数の最小値を表示
        private static void Exercise02(List<int> numbers) {
            var min = numbers.Where(x => x % 2 == 1).Min();
            Console.WriteLine(min);


        }
        //問題３　偶数のみを昇順に並べて表示（遅延実行とする）
        private static void Exercise03(List<int> numbers) {
            var sort = numbers.Where(x => x % 2 == 0).OrderBy(x => x);
            foreach (int x in sort) Console.Write(" " + x);


        }

        //問題４　0以上30未満の数字のみを表示（即時実行でも可とする）
        private static void Exercise04(List<int> numbers) {
            var number_0 = numbers.Where(x => x >= 0 && x < 30);
            foreach (int x in number_0) Console.Write(" " + x);

        }

        //問題５　最高年齢を表示
        private static void Exercise05(List<Person> persons) {
            var max=persons.Max(x => x.Age);
            Console.WriteLine(max+"歳");

        }

        //問題６　年齢20代だけの平均身長を表示
        private static void Exercise06(List<Person> persons) {
           var average_height=persons.Where(x=>x.Age < 30).Average(x => x.Height);
            Console.WriteLine(average_height+"cm");


        }

        //問題７　身長170cm以上の「名前と年齢と体重」を全員表示
        private static void Exercise07(List<Person> persons) {
            var height = persons.Where(x => x.Height >= 170).ToArray();
            foreach (var person in height) {
                Console.WriteLine(person.Name+" " + person.Age+"歳" + person.Weight+"kg");
            }
        }

        //問題８　名前の漢字４文字の人を全て表示
        private static void Exercise08(List<Person> persons) {
          // var name = persons
            


        }
    }
}
