using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var PrefOfficeDict = new Dictionary<string, string>();
            Console.WriteLine("県庁所在地の登録");

            for (int i = 0; i < 5; i++) {
                //都道府県の入力
                Console.Write("都道府県:");
                string pref = Console.ReadLine();

                //県庁所在地の入力
                Console.Write("県庁所在地:");
                string prefcap = Console.ReadLine();

                if (PrefOfficeDict.ContainsKey(pref)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    var ReWrite = Console.ReadLine();
                    if (ReWrite == "Y") {
                        PrefOfficeDict[pref] = prefcap;   //上書きする
                    }
                } else {
                    //登録
                    PrefOfficeDict.Add(pref, prefcap);
                }
            }
            Console.WriteLine();  //改行

            Boolean endFlag = false;   
            while (!endFlag) {
                Console.WriteLine("//メニュー//");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("9:終了");
                Console.WriteLine(">");
                String menuSelect = Console.ReadLine();
                switch (menuSelect) {
                    case "1":
                        //一覧
                        foreach (var pref in PrefOfficeDict) {
                            Console.WriteLine("{0}の県庁所在地は{1}です。", pref.Key, pref.Value);
                        }

                        break;

                    case "2":
                        //都道府県の入力
                        Console.WriteLine("都道府県:");
                        String searchPref = Console.ReadLine();
                        Console.WriteLine(searchPref + "の県庁所在地は" + PrefOfficeDict[searchPref] + "です。");

                        break;

                    case "9":
                        endFlag = true;
                        break;


                }
            }
        }
    }
}



























/*  var flowerDict = new Dictionary<string, int>() {
  { "sunflower", 400 },
  { "pansy", 300 },
  { "tulip", 350 },
  { "rose", 500 },
  { "dahlia", 450 },
   };
  Console.WriteLine(flowerDict["sunflower"]);
  Console.WriteLine(flowerDict["dahlia"]);
*/

/*var employeeDict = new Dictionary<int, Employee> {
 { 100, new Employee(100, "清水遼久") },
 { 112, new Employee(112, "芹沢洋和") },
 { 125, new Employee(125, "岩瀬奈央子") },
};

employeeDict.Add(126, new Employee(126, "庄野和花"));


foreach(var item in employeeDict.Keys) {
    Console.WriteLine($"{item}");
}



//削除
var result = employeeDict.Remove(126);

}
}
}
*/