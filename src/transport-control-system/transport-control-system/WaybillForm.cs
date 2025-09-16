using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class WaybillForm : Form
    {
        public WaybillForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (vehicleCombo.SelectedItem == null || driverCombo.SelectedItem == null)
            {
                MessageBox.Show("Выберите транспортное средство и водителя", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string vehicle = vehicleCombo.SelectedItem.ToString();
                string driver = driverCombo.SelectedItem.ToString();
                string route = routeCombo.SelectedItem?.ToString() ?? "Не указан";
                decimal fuel = fuelNumeric.Value;
                int mileage = (int)mileageNumeric.Value;

                // Заглушка вместо обращения к БД
                bool success = true; // Всегда успешно

                if (success)
                {
                    MessageBox.Show("Путевой лист успешно создан!", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при создании путевого листа", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadComboBoxData()
        {
            // Заглушка - загружаем тестовые данные
            vehicleCombo.Items.Add("А123БВ777 - ГАЗ ГАЗель Next");
            vehicleCombo.Items.Add("В456ГД777 - КамАЗ 5320");
            vehicleCombo.Items.Add("Е789ЖЗ777 - Форд Transit");

            driverCombo.Items.Add("Иванов Иван Иванович");
            driverCombo.Items.Add("Петров Петр Петрович");
            driverCombo.Items.Add("Сидоров Сидор Сидорович");

            routeCombo.Items.Add("Не выбран");
            routeCombo.Items.Add("Центр - Север");
            routeCombo.Items.Add("Склад - Магазин №1");
            routeCombo.Items.Add("Междугородний");

            if (routeCombo.Items.Count > 0)
                routeCombo.SelectedIndex = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadComboBoxData();
        }
    }
}