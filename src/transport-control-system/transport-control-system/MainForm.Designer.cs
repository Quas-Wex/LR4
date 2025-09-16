using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip mainMenuStrip;
        private Panel dashboardPanel;
        private Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainMenuStrip = new MenuStrip();
            this.dashboardPanel = new Panel();
            this.titleLabel = new Label();
            this.SuspendLayout();

            // MainForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 800);
            this.Text = "Система управления транспортом";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            // mainMenuStrip
            this.mainMenuStrip.ImageScalingSize = new Size(20, 20);
            this.mainMenuStrip.Location = new Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new Size(1200, 30);
            this.mainMenuStrip.TabIndex = 0;

            // Создаем меню
            CreateMainMenu();

            // dashboardPanel
            this.dashboardPanel.Dock = DockStyle.Fill;
            this.dashboardPanel.Location = new Point(0, 30);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new Size(1200, 770);
            this.dashboardPanel.TabIndex = 1;
            this.dashboardPanel.BackColor = Color.WhiteSmoke;

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.titleLabel.ForeColor = Color.DarkBlue;
            this.titleLabel.Location = new Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new Size(456, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Панель управления транспортом";

            // Создаем карточки статистики
            CreateStatCards();

            this.dashboardPanel.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CreateMainMenu()
        {
            // Транспорт
            var vehiclesMenu = new ToolStripMenuItem("Транспорт");
            vehiclesMenu.DropDownItems.Add("Список ТС", null, OpenVehiclesList);
            vehiclesMenu.DropDownItems.Add("Мониторинг", null, OpenMonitoring);

            // Водители
            var driversMenu = new ToolStripMenuItem("Водители");
            driversMenu.DropDownItems.Add("Список водителей", null, OpenDriversList);

            // Маршруты
            var routesMenu = new ToolStripMenuItem("Маршруты");
            routesMenu.DropDownItems.Add("Управление маршрутами", null, OpenRoutes);

            // Топливо
            var fuelMenu = new ToolStripMenuItem("Топливо");
            fuelMenu.DropDownItems.Add("Расход топлива", null, OpenFuelLog);

            // Путевые листы
            var waybillMenu = new ToolStripMenuItem("Путевые листы");
            waybillMenu.DropDownItems.Add("Создать путевой лист", null, CreateWaybill);
            waybillMenu.DropDownItems.Add("Активные путевые листы", null, OpenActiveWaybills);

            // Техосмотр
            var inspectionMenu = new ToolStripMenuItem("Техосмотр");
            inspectionMenu.DropDownItems.Add("Журнал осмотров", null, OpenInspections);

            // Настройки
            var settingsMenu = new ToolStripMenuItem("Настройки");
            settingsMenu.DropDownItems.Add("Подключение к БД", null, OpenDatabaseSettings);

            this.mainMenuStrip.Items.AddRange(new ToolStripItem[] {
                vehiclesMenu, driversMenu, routesMenu, fuelMenu, waybillMenu, inspectionMenu, settingsMenu
            });
        }

        private void CreateStatCards()
        {
            // Карточка "Всего ТС"
            var vehicleCard = new GroupBox();
            vehicleCard.Text = "Транспортные средства";
            vehicleCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            vehicleCard.ForeColor = Color.DarkBlue;
            vehicleCard.Location = new Point(50, 100);
            vehicleCard.Size = new Size(220, 140);

            var vehicleValueLabel = new Label();
            vehicleValueLabel.Name = "vehicleValue";
            vehicleValueLabel.Text = "0";
            vehicleValueLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            vehicleValueLabel.ForeColor = Color.Blue;
            vehicleValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            vehicleValueLabel.Dock = DockStyle.Fill;
            vehicleCard.Controls.Add(vehicleValueLabel);

            // Карточка "Активные водители"
            var driverCard = new GroupBox();
            driverCard.Text = "Активные водители";
            driverCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            driverCard.ForeColor = Color.DarkGreen;
            driverCard.Location = new Point(320, 100);
            driverCard.Size = new Size(220, 140);

            var driverValueLabel = new Label();
            driverValueLabel.Name = "driverValue";
            driverValueLabel.Text = "0";
            driverValueLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            driverValueLabel.ForeColor = Color.Green;
            driverValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            driverValueLabel.Dock = DockStyle.Fill;
            driverCard.Controls.Add(driverValueLabel);

            // Карточка "Активные путевые листы"
            var waybillCard = new GroupBox();
            waybillCard.Text = "Активные путевые листы";
            waybillCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            waybillCard.ForeColor = Color.DarkOrange;
            waybillCard.Location = new Point(590, 100);
            waybillCard.Size = new Size(220, 140);

            var waybillValueLabel = new Label();
            waybillValueLabel.Name = "waybillValue";
            waybillValueLabel.Text = "0";
            waybillValueLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            waybillValueLabel.ForeColor = Color.Orange;
            waybillValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            waybillValueLabel.Dock = DockStyle.Fill;
            waybillCard.Controls.Add(waybillValueLabel);

            // Карточка "ТС на линии"
            var activeCard = new GroupBox();
            activeCard.Text = "ТС на линии";
            activeCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            activeCard.ForeColor = Color.DarkRed;
            activeCard.Location = new Point(860, 100);
            activeCard.Size = new Size(220, 140);

            var activeValueLabel = new Label();
            activeValueLabel.Name = "activeValue";
            activeValueLabel.Text = "0";
            activeValueLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            activeValueLabel.ForeColor = Color.Red;
            activeValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            activeValueLabel.Dock = DockStyle.Fill;
            activeCard.Controls.Add(activeValueLabel);

            this.dashboardPanel.Controls.Add(vehicleCard);
            this.dashboardPanel.Controls.Add(driverCard);
            this.dashboardPanel.Controls.Add(waybillCard);
            this.dashboardPanel.Controls.Add(activeCard);
        }
    }
}