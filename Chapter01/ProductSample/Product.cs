﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    public class Product {
        //商品コード
        public int Code { get; set; }  //自動実装プロパティ
        //商品名
        public string Name { get; set; }
        //商品価格（税抜き）
        public int Price { get; set; }

        public Product(int code, string name, int price) {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }


        //消費税額を求める（消費税率は8%）
        public int GetTax() {
            return (int)(Price * 0.08);
        }

        //税込価格を求める
        public int GetPriceIncludingTax() {
            return Price + GetTax();

        }
    }
}

