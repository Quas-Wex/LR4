using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    partial class WaybillForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label titleLabel;
        private Label vehicleLabel;
        private ComboBox vehicleCombo;
        private Label driverLabel;
        private ComboBox driverCombo;
        private Label routeLabel;
        private ComboBox routeCombo;
        private Label fuelLabel;
        private NumericUpDown fuelNumeric;
        private Label mileageLabel;
        private NumericUpDown mileageNumeric;
        private Button createButton;
        private Button cancelButton;

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
            this.titleLabel = new Label();
            this.vehicleLabel = new Label();
            this.vehicleCombo = new ComboBox();
            this.driverLabel = new Label();
            this.driverCombo = new ComboBox();
            this.routeLabel = new Label();
            this.routeCombo = new ComboBox();
            this.fuelLabel = new Label();
            this.fuelNumeric = new NumericUpDown();
            this.mileageLabel = new Label();
            this.mileageNumeric = new NumericUpDown();
            this.createButton = new Button();
            this.cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.fuelNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageNumeric)).BeginInit();
            this.SuspendLayout();

            // WaybillForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(520, 420);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaybillForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Создание путевого листа";

            // titleLabel
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.titleLabel.ForeColor = Color.DarkBlue;
            this.titleLabel.Location = new Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new Size(209, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Новый путевой лист";

            // vehicleLabel
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Location = new Point(20, 70);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new Size(184, 20);
            this.vehicleLabel.TabIndex = 1;
            this.vehicleLabel.Text = "Транспортное средство:";

            // vehicleCombo
            this.vehicleCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.vehicleCombo.FormattingEnabled = true;
            this.vehicleCombo.Location = new Point(20, 95);
            this.vehicleCombo.Name = "vehicleCombo";
            this.vehicleCombo.Size = new Size(460, 28);
            this.vehicleCombo.TabIndex = 2;

            // driverLabel
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new Point(20, 140);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new Size(77, 20);
            this.driverLabel.TabIndex = 3;
            this.driverLabel.Text = "Водитель:";

            // driverCombo
            this.driverCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.driverCombo.FormattingEnabled = true;
            this.driverCombo.Location = new Point(20, 165);
            this.driverCombo.Name = "driverCombo";
            this.driverCombo.Size = new Size(460, 28);
            this.driverCombo.TabIndex = 4;

            // routeLabel
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new Point(20, 210);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new Size(190, 20);
            this.routeLabel.TabIndex = 5;
            this.routeLabel.Text = "Маршрут (необязательно):";

            // routeCombo
            this.routeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.routeCombo.FormattingEnabled = true;
            this.routeCombo.Location = new Point(20, 235);
            this.routeCombo.Name = "routeCombo";
            this.routeCombo.Size = new Size(460, 28);
            this.routeCombo.TabIndex = 6;

            // fuelLabel
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Location = new Point(20, 280);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new Size(141, 20);
            this.fuelLabel.TabIndex = 7;
            this.fuelLabel.Text = "Выдано топлива (л):";

            // fuelNumeric
            this.fuelNumeric.DecimalPlaces = 2;
            this.fuelNumeric.Location = new Point(20, 305);
            this.fuelNumeric.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.fuelNumeric.Name = "fuelNumeric";
            this.fuelNumeric.Size = new Size(150, 27);
            this.fuelNumeric.TabIndex = 8;

            // mileageLabel
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new Point(200, 280);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new Size(165, 20);
            this.mileageLabel.TabIndex = 9;
            this.mileageLabel.Text = "Начальный пробег (км):";

            // mileageNumeric
            this.mileageNumeric.Location = new Point(200, 305);
            this.mileageNumeric.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            this.mileageNumeric.Name = "mileageNumeric";
            this.mileageNumeric.Size = new Size(150, 27);
            this.mileageNumeric.TabIndex = 10;

            // createButton
            this.createButton.BackColor = Color.LightGreen;
            this.createButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.createButton.Location = new Point(200, 360);
            this.createButton.Name = "createButton";
            this.createButton.Size = new Size(120, 40);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new EventHandler(this.CreateButton_Click);

            // cancelButton
            this.cancelButton.BackColor = Color.LightCoral;
            this.cancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.cancelButton.Location = new Point(340, 360);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new Size(120, 40);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new EventHandler(this.CancelButton_Click);

            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.vehicleCombo);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.driverCombo);
            this.Controls.Add(this.routeLabel);
            this.Controls.Add(this.routeCombo);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.fuelNumeric);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.mileageNumeric);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);

            ((System.ComponentModel.ISupportInitialize)(this.fuelNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}