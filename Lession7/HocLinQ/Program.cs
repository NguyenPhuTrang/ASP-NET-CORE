using System;
using System.Collections.Generic;
using System.Linq;


namespace HocLinQ
{
    class Program
    {   //Khoi tao danh sach Branchs
        static List<Brand> brands = new List<Brand>()
        {
            new Brand(){BrandId="B001", BrandName="Cong ty FPT"},
            new Brand(){BrandId="B002", BrandName="Nha Sach Tri Tue"},
            new Brand(){BrandId="B003", BrandName="Cong Ty CP"},
            new Brand(){BrandId="B004", BrandName="Cong ty VNPT"}
        };
        static List<Product> products = new List<Product>()
        {
            new Product(){ProductId="P01",ProductName="Ban Hoc",price=1000,Colors=new string[]{"Trang","Hong",},BranchId="B001" },
            new Product(){ProductId="P01",ProductName="Sach Hoc",price=2000,Colors=new string[]{"Do","Den",},BranchId="B002" },
            new Product(){ProductId="P01",ProductName="Vo Hoc",price=3000,Colors=new string[]{"Vang","Xanh",},BranchId="B003" },
            new Product(){ProductId="P01",ProductName="But Hoc",price=4000,Colors=new string[]{"Tim","Xam",},BranchId="B004" }
        };
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //1 Phep chieu (Projection)
            //Lay danh sach cac thuong hieu
            // Query syntax
            // var result1 = from b in brands select b;
            // Tra ve doi tuong vo danh
            // var result1 = from b in brands
            //              select new
            //              {
            //                 math = b.BrandId,
            //                  tenth = b.BrandName
            //              };
            // Method syntax
            //var result1 = brands.Select(b => b); // Tham so truyen vao duoi dang bieu thuc Lamda
            //var result1 = brands.Select(b => new
            //{
            //    math = b.BrandId,
            //    tenth = b.BrandName
            //});
            //Console.WriteLine("DANH SÁCH CÁC THƯƠNG HIỆU");
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.tenth}");
            //}

            //. Phep loc 
            // Lay ra san pham co mau xanh
            // Query syntax
            //var result2 = products.Where(p => p.Colors.Contains("Xanh"));            
            //Console.WriteLine("---Danh Sach Cac San Pham Mau Xanh---");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{ item.ProductId}, { item.ProductName}");
            //}
            //3.Phep noi (join)
            // Lay ra tat ca cac san pham bao gom cac thong tin :
            // Ma san pham , ten san pham , gia , ten thuong hieu
            // Query syntax
            //var result3 = from p in products
            //              join b in brands on p.BranchId equals b.BrandId
            //              select new
            //              {
            //                  masp = p.ProductId,
            //                  tensp = p.ProductName,
            //                  gia = p.price,
            //                  tenth = b.BrandName
            //              };
            // - Method syntax
            //var result3 = products.Join(brands, p => p.BranchId, b => b.BrandId, (p, b) => new {
            //    masp = p.ProductId,
            //    tensp = p.ProductName,
            //    gia = p.price,
            //    tenth = b.BrandName
            //});
            //foreach(var item in result3)
            //{
            //    Console.WriteLine($"{item.masp}, {item.tensp}, {item.gia}, {item.tenth}");
            //}
            //4.Sap xep (sort)
            //Lay danh sach cac san pham duoc sap xep theo gia
            // Query syntax
            //var result4 = from p in products
            //              orderby p.price ascending// tang dan; descending giam dan
            //              select p;
            //var result5 = products.Select(p => p)OrderByDescending(p => p.Price).ThenByDescending(p => p.ProductId);
            //Console.WriteLine("---Danh sach san pham dc sap xep theo gia---");
            //foreach (var item in result5)
            //{
            //    Console.WriteLine($"{item.ProductId}, {item.ProductName},{item.BranchId}, {item.price}");
            //}
            // 5 Gom nhom
            var result6 = from p in products
                          group p by p.BranchId;
            Console.WriteLine("Danh sach cac san pham nhom theo thuong hieu");
            foreach(var group in result6)
            {
                Console.WriteLine("Nhan hieu: "+group.Key);
            }
            //foreach (var item in group)
            //{
            //    Console.WriteLine($"/t+{item.ProductId},{item.ProductName}");
            //}
            //// 6. Toan tu chuyen kieu
            //Brand[] arrBrand = brands.ToArray();
            //// 7. Toan tu noi
            //List<string> list1 = new List<string>() { "Mot", "Hai", "Ba" };
            //List<string> list2 = new List<string>() { "Bon", "Nam", "Sau" };
            ////var list3 = list1.Concat(list2);
            //foreach (var item in list3)
            //    {
            //    Console.WriteLine(item+" ");
            //    }

            // 8 Toan tu tong hop 
            var sosp = products.Count();
            Console.WriteLine("Tong so san pham : " + sosp);
            var giaMax = products.Max(x => x.price);
            Console.WriteLine("gia cao nhat: "+giaMax);
            // 9 . Toan tu dinh luong
            bool check = products.All(p => p.price > 1000);
            { 
                if(check)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            //10 Toán tử phân vùng : Skip ; SkipWhile; Take ; TakeWhile;
            List<string> list4 = new List<string>()
            {
                "Mot", "hai", "Ba", "Bon", "Nam", "Sau", "Bay", "Tam", "Chin"
            };
            //var result6 = list4.Take(4);
            var result7 = list4.Skip(5);
            foreach(var item in result7)
            {
                Console.WriteLine(item+ "");
            }
            //11. Tóan tử sinh dữ liệu 
            var list5 = Enumerable.Empty<string>();
            Console.WriteLine(list5.Count());
            var list6 = Enumerable.Range(10, 6);
            foreach (var item in list6)
            {
                Console.WriteLine(item+" ");
            }
            //12 . Toán tử phần tử 
            List<int> list7 = new List<int>() { 20, 3, 4, 9, 12, 7, 13 };
            Console.WriteLine(list7.First());
            Console.WriteLine(list7.First(x=>x < 1));
            Console.WriteLine(list7.FirstOrDefault(x => x <1));
            Console.WriteLine(list7.Last());

            var result8 = products.First(p => p.ProductId == "P09");
            var result9 = products.First(p => p.ProductId == "P09");

        }
    }
}

