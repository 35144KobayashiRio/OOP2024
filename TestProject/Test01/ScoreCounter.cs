using System;
using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要:スコアデータを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> score = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student students = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                score.Add(students);
            }
            return score;
        }

        internal IEnumerable<object> GetPerStudentScore() {
            throw new NotImplementedException();
        }
    }

    //メソッドの概要：科目別の点数を求める
    public IDictionary<string, int> GetPerStudentScore() {
        var dict = new Dictionary<string, int>();
        foreach (Student students in _score) {
            if (dict.ContainsKey(students.Name)) {
                dict[students.Name] += students.Score;
            } else {
                dict[students.Name] = students.Score;
            }
        }
        return dict;
    }
}