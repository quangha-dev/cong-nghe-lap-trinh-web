using System;
using System.Text.Json; // Sử dụng thư viện System.Text.Json

class Program
{
    // Hàm tính toán và trả về JSON string
    static string TinhToan(double r)
    {
        // Tính toán diện tích, chu vi và đường kính
        double dienTich = Math.PI * r * r;
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        // Tạo object để serialize thành JSON
        var ketQua = new
        {
            dien_tich = dienTich,
            chu_vi = chuVi,
            duong_kinh = duongKinh
        };

        // Serialize object thành JSON string
        return JsonSerializer.Serialize(ketQua);
    }

    static void Main(string[] args)
    {
        double r;

        while (true)
        {
            Console.Write("Nhập bán kính hình tròn (r): ");
            string input = Console.ReadLine();

            // Kiểm tra giá trị nhập vào có hợp lệ hay không
            if (double.TryParse(input, out r) && r > 0)
            {
                break; // Thoát vòng lặp nếu nhập đúng
            }
            else
            {
                Console.WriteLine("Bán kính phải là một số dương. Vui lòng nhập lại!");
            }
        }

        // Gọi hàm tính toán và hiển thị kết quả
        string ketQuaJson = TinhToan(r);
        Console.WriteLine("Kết quả: " + ketQuaJson);
    }
}