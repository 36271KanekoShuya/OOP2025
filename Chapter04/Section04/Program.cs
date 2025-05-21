﻿using System;
using System.IO.Compression;

namespace Section04 {
    internal class Program {
        static void Main(string[] args) {

            #region nullの判定
            string? name = null;

            if (name is null) {
                Console.WriteLine("nameはnullです");
            }
            #endregion

            #region null合体演算子
            string code = "12345";
            var message = GetMessage(code) ?? DefaultMessage();
            Console.WriteLine(message);
            #endregion

            #region  null条件演算子
            Sale? sale = new Sale {
                ShopName = "新宿店",
                ProductCategory = "洋菓子",
                Amount = 523100
            };
            Console.WriteLine(sale);
            #endregion

            #region 値の入れ替え
            int a = 10; int b = 20;
            Console.WriteLine("a = " + a + "b=" + b);
           (b, a) = (a, b);
            //旧式swapアルゴリズム
            //int work = a;
            //a = b;
            //b = work;
            Console.WriteLine("a = " + a + "b=" + b);
            #endregion

            #region　tryとTryParse
            string? inputData = Console.ReadLine();
            if(int.TryParse(inputData,out var number)) {
                Console.WriteLine(number);
            } else {
                Console.WriteLine("エラー");
            }
            //try {
            //int num = int.Parse(inputData);
            //Console.WriteLine(num);
            //}
            //catch (FormatException e) {
            //    //Console.WriteLine(e.Message);
            //    Console.WriteLine("フォーマットエラー");
            //}
            //catch(OverflowException e) {
            //    Console.WriteLine("入力値が大きすぎます");
            //}
            //finally {
            //    Console.WriteLine("処理完了");
            //}
            //Console.WriteLine("メソッド終了");
            #endregion
        }
        private static object? GetMessage(string code) {
            return null;
        }
        private static object? DefaultMessage() {
            return "DefaultMessage";
        }
        //売り上げクラス
        public class Sale {
            //店舗名
            public string ShopName { get; set; } = string.Empty;
            //商品カテゴリ
            public string ProductCategory { get; set; } = string.Empty;
            //売上高
            public int Amount { get; set; }

        }
    }
}
