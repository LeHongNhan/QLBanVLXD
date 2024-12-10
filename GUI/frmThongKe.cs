using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DevExpress.XtraCharts;
using System.Data.SqlClient;
using System.Globalization;
namespace GUI
{
    public partial class frmThongKe : DevExpress.XtraEditors.XtraForm
    {
        BLLDonHang donHang;
        BLLSanPham sanPham;
        public frmThongKe()
        {
            
            InitializeComponent();
            LoadChartThongKe();
        }
        public void LoadChartThongKe()
        {
            BLLDonHang donHang = new BLLDonHang();

            // Lấy dữ liệu từ BLL
            var data = donHang.GetTongTienTheoNgay();

            // Gán dữ liệu vào ChartControl
            chartThongKe.DataSource = data;

            // Xóa series cũ
            chartThongKe.Series.Clear();

            // Tạo series mới
            Series series = new Series("Tổng tiền", ViewType.Bar);

            // Cấu hình dữ liệu cho series
            series.ArgumentDataMember = "NgayLap"; // Trục X: Ngày lập
            series.ValueDataMembers.AddRange("TongTien"); // Trục Y: Tổng tiền

            // Thêm series vào ChartControl
            chartThongKe.Series.Add(series);

            // Tùy chỉnh tiêu đề
            chartThongKe.Titles.Clear();
            chartThongKe.Titles.Add(new ChartTitle { Text = "Tổng tiền theo ngày lập" });
        }
        private void LoadDataToChart()
        {
            // Khởi tạo BLLDonHang
            BLLDonHang bllDonHang = new BLLDonHang();

            // Lấy giá trị từ DateTimePickers
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay = dtpDenNgay.Value;

            // Lọc dữ liệu từ BLL theo khoảng thời gian
            var data = bllDonHang.GetTongTienTheoNgay()
                .Where(x => x.NgayLap >= tuNgay && x.NgayLap <= denNgay)
                .ToList();

            // Gắn dữ liệu vào ChartControl
            chartThongKe.Series.Clear();
            Series series = new Series("Doanh thu theo ngày", ViewType.Bar);
            series.ArgumentDataMember = "NgayLap";  // Trục X
            series.ValueDataMembers.AddRange("TongTien");  // Trục Y
            BarSeriesLabel label = (BarSeriesLabel)series.Label;
            label.Visible = true; // Hiển thị Label
            label.TextPattern = "{V:#,##0} đ";
            chartThongKe.DataSource = data;
            chartThongKe.Series.Add(series);
        }
        private void chartThongKe_Click(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataToChart();
            LoadTongDoanhThuTheoNgay();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }
        private void LoadTongDoanhThuTheoNgay()
        {
            // Tạo đối tượng BLLDonHang
            BLLDonHang bllDonHang = new BLLDonHang();

            // Lấy giá trị từ DateTimePickers
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            // Lấy tổng doanh thu theo ngày từ BLL
            decimal tongDoanhThu = bllDonHang.GetTongDoanhThuTheoNgay(tuNgay, denNgay);
            var culture = new CultureInfo("vi-VN");
            // Gắn giá trị lên Label
            lblTongDoanhThu.Text = $"Tổng doanh thu từ {tuNgay:dd/MM/yyyy} đến {denNgay:dd/MM/yyyy} là: {tongDoanhThu.ToString("C",culture)}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}