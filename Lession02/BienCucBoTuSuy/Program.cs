// See https://aka.ms/new-console-template for more information
using BienCucBoTuSuy;
using System.Net.Cache;

Console.WriteLine("Hello, World!");
//Khai báo biến 
// khai báo biến cục bộ tự suy bằng từ khóa var tự động nhận biết kiểu dữ liệu 
var a = 20;
Product pr = new Product() { ProductId = 1 , ProductName = "Machine"};
// Kiểu nặc danh sử dụng nhanh gọn lẹ tạo đối tượng mà không cần tạo class .
var employee = new
{
    Name = " NPT",
    Age = 25,
    Phone = "0273642378"
};
Console.WriteLine(employee.Name);



