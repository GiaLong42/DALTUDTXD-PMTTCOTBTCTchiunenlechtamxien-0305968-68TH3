using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


using Fluent; 

namespace DALTUDTXD_AppTTvaTKCOBTCTCHIUNENLECHTAMXIEN_DangGiaKhanh_0305968_68TH3
{
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnXuatEtabs_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Đang kết nối với ETABS qua API...\nVui lòng đảm bảo ETABS đang mở mô hình của bạn.",
                            "Kết nối ETABS", MessageBoxButton.OK, MessageBoxImage.Information);

            
        }
    }
}