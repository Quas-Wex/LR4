using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class VehicleListForm : Form
    {
        private DatabaseManager dbManager;

        public VehicleListForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            try
            {
                var vehicles = dbManager.GetVehicles();
                vehiclesGrid.DataSource = vehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadVehicles();
            MessageBox.Show("Данные обновлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция добавления ТС будет реализована в следующей версии", "Информация",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (vehiclesGrid.SelectedRows.Count > 0)
            {
                MessageBox.Show("Функция редактирования ТС будет реализована в следующей версии", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите транспортное средство для редактирования", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (vehiclesGrid.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное ТС?", "Подтверждение",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Функция удаления ТС будет реализована в следующей версии", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите транспортное средство для удаления", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}