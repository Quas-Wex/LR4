using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    public partial class DriversListForm : Form
    {
        private DatabaseManager dbManager;

        public DriversListForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadDrivers();
        }

        private void LoadDrivers()
        {
            try
            {
                var drivers = dbManager.GetDrivers();
                driversGrid.DataSource = drivers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadDrivers();
            MessageBox.Show("Данные обновлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция добавления водителя будет реализована в следующей версии", "Информация",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (driversGrid.SelectedRows.Count > 0)
            {
                MessageBox.Show("Функция редактирования водителя будет реализована в следующей версии", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите водителя для редактирования", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (driversGrid.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранного водителя?", "Подтверждение",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Функция удаления водителя будет реализована в следующей версии", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите водителя для удаления", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}