using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager;

        public MainForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                var stats = dbManager.GetDashboardStats();
                UpdateStatCard("vehicleValue", stats["total_vehicles"].ToString());
                UpdateStatCard("driverValue", stats["active_drivers"].ToString());
                UpdateStatCard("waybillValue", stats["active_waybills"].ToString());
                UpdateStatCard("activeValue", stats["vehicles_on_route"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatCard(string controlName, string value)
        {
            foreach (Control card in dashboardPanel.Controls)
            {
                if (card is GroupBox groupBox)
                {
                    foreach (Control label in groupBox.Controls)
                    {
                        if (label.Name == controlName)
                        {
                            label.Text = value;
                            break;
                        }
                    }
                }
            }
        }

        private void OpenVehiclesList(object sender, EventArgs e)
        {
            var vehicleForm = new VehicleListForm();
            vehicleForm.ShowDialog();
        }

        private void OpenDriversList(object sender, EventArgs e)
        {
            var driversForm = new DriversListForm();
            driversForm.ShowDialog();
        }

        private void CreateWaybill(object sender, EventArgs e)
        {
            var waybillForm = new WaybillForm();
            waybillForm.ShowDialog();
            LoadDashboardData();
        }

        private void OpenMonitoring(object sender, EventArgs e)
        {
            MessageBox.Show("Функция мониторинга будет реализована позже", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenRoutes(object sender, EventArgs e)
        {
            MessageBox.Show("Функция управления маршрутами будет реализована позже", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenFuelLog(object sender, EventArgs e)
        {
            MessageBox.Show("Функция журнала топлива будет реализована позже", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenActiveWaybills(object sender, EventArgs e)
        {
            MessageBox.Show("Функция активных путевых листов будет реализована позже", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenInspections(object sender, EventArgs e)
        {
            MessageBox.Show("Функция техосмотров будет реализована позже", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenDatabaseSettings(object sender, EventArgs e)
        {
            MessageBox.Show("Функция настроек БД будет реализована позже", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}