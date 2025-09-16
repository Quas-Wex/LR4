using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransportManagement
{
    partial class VehicleListForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView vehiclesGrid;
        private Panel buttonPanel;
        private Button refreshButton;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;

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
            this.vehiclesGrid = new DataGridView();
            this.buttonPanel = new Panel();
            this.refreshButton = new Button();
            this.addButton = new Button();
            this.editButton = new Button();
            this.deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGrid)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();

            // VehicleListForm
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 600);
            this.Text = "Список транспортных средств";
            this.StartPosition = FormStartPosition.CenterParent;
            this.MinimumSize = new Size(800, 500);

            // vehiclesGrid
            this.vehiclesGrid.AllowUserToAddRows = false;
            this.vehiclesGrid.AllowUserToDeleteRows = false;
            this.vehiclesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.vehiclesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesGrid.Dock = DockStyle.Fill;
            this.vehiclesGrid.Location = new Point(0, 0);
            this.vehiclesGrid.MultiSelect = false;
            this.vehiclesGrid.Name = "vehiclesGrid";
            this.vehiclesGrid.ReadOnly = true;
            this.vehiclesGrid.RowHeadersWidth = 51;
            this.vehiclesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.vehiclesGrid.Size = new Size(900, 540);
            this.vehiclesGrid.TabIndex = 0;

            // buttonPanel
            this.buttonPanel.Dock = DockStyle.Bottom;
            this.buttonPanel.Location = new Point(0, 540);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new Size(900, 60);
            this.buttonPanel.TabIndex = 1;
            this.buttonPanel.BackColor = Color.LightGray;

            // refreshButton
            this.refreshButton.Location = new Point(12, 15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new Size(100, 30);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new EventHandler(this.RefreshButton_Click);

            // addButton
            this.addButton.Location = new Point(130, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new Size(100, 30);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.BackColor = Color.LightGreen;
            this.addButton.Click += new EventHandler(this.AddButton_Click);

            // editButton
            this.editButton.Location = new Point(248, 15);
            this.editButton.Name = "editButton";
            this.editButton.Size = new Size(100, 30);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.BackColor = Color.LightBlue;
            this.editButton.Click += new EventHandler(this.EditButton_Click);

            // deleteButton
            this.deleteButton.Location = new Point(366, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new Size(100, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.BackColor = Color.LightCoral;
            this.deleteButton.Click += new EventHandler(this.DeleteButton_Click);

            this.buttonPanel.Controls.Add(this.refreshButton);
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Controls.Add(this.editButton);
            this.buttonPanel.Controls.Add(this.deleteButton);

            this.Controls.Add(this.vehiclesGrid);
            this.Controls.Add(this.buttonPanel);

            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGrid)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}