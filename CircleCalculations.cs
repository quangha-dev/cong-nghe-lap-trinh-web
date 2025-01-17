
using System;
using System.Text.Json;

class Program
{
    // Hàm tính diện tích, chu vi và đường kính
    static string CalculateCircleProperties(double r)
    {
        double dienTich = Math.PI * r * r;
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        var result = new
        {
            dien_tich = dienTich,
            chu_vi = chuVi,
            duong_kinh = duongKinh
        };

        return JsonSerializer.Serialize(result);
    }

    static void Main(string[] args)
    {
        double r;
        while (true)
        {
            Console.Write("Nhập bán kính hình tròn (r): ");
            string input = Console.ReadLine();

            // Kiểm tra giá trị nhập có hợp lệ hay không
            if (double.TryParse(input, out r) && r > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Bán kính phải là một số dương hợp lệ. Vui lòng nhập lại.");
            }
        }

        // Gọi hàm tính toán và hiển thị kết quả
        string resultJson = CalculateCircleProperties(r);
        Console.WriteLine("Kết quả: " + resultJson);
    }
}
