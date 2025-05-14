﻿using System.Data;

namespace Section01 {
    internal class Program {
        public delegate bool Judgement(int value);//デリゲートの宣言
        static void Main(string[] args) {
            //Console.Write("カウントする数値:");
            //int num = int.Parse(Console.ReadLine());
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            Judgement judge = IsEven;
            Console.WriteLine(Count(numbers,judge));
        }
        //メソッドへ渡す処理
        static bool IsEven(int n) {
            return n % 2 == 0;
        }
        private static int Count(int[] numbers,Judgement judge) {
            //var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            var count = 0;
            foreach (var n in numbers) {
                //引数で受け取ったメソッドを呼びだす
                if (judge(n) == true) {
                    count++;
                }
            }
            return count;
        }
    }
}
