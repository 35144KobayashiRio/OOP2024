using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {

            String pref, prefcap;

            //入力
            Console.WriteLine("県庁所在地の登録");
            while (true) {
                //都道府県の入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();

                if (pref == null) {
                    break;
                }

                //県庁所在地の入力
                Console.Write("県庁所在地:");
                prefcap = Console.ReadLine();

                //都道府県が登録されているか
                if (prefOfficeDict.ContainsKey(pref)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") {
                        continue;
                    }
                }
                prefOfficeDict[pref] = prefcap;  //登録
            }
            Console.WriteLine();//改行

            Boolean endFlag = false;    //終了フラグ
            while (!endFlag) {
                switch (menuDisp()) {
                    case "1":
                        //一覧表示
                        allDisp();
                        break;

                    case "2":
                        //検索処理
                        searchPrefCaptalLocation();
                        break;

                    case "9":
                        endFlag = true; //終了フラグ
                        break;
                }
            }
        }

        //検索処理
        private static void searchPrefCaptalLocation() {
            Console.Write("都道府県:");
            String searchPref = Console.ReadLine();
            Console.WriteLine(searchPref + "の県庁所在地は" + prefOfficeDict[searchPref] + "です");
        }

        //一覧表示
        private static void allDisp() {
            foreach (var item in prefOfficeDict) {
                Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
            }
        }

        //メニュー表示
        private static string menuDisp() {
            Console.WriteLine("// メニュー //");
            Console.WriteLine("1：一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9：終了");
            Console.Write(">");
            String menuSelect = Console.ReadLine();
            return menuSelect;
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