namespace TransportManagement
{
    partial class DriversListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView driversGrid;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;

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
            this.driversGrid = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.driversGrid)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();

            // DriversListForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Список водителей";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MinimumSize = new System.Drawing.Size(700, 400);

            // driversGrid
            this.driversGrid.AllowUserToAddRows = false;
            this.driversGrid.AllowUserToDeleteRows = false;
            this.driversGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driversGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driversGrid.Location = new System.Drawing.Point(0, 0);
            this.driversGrid.MultiSelect = false;
            this.driversGrid.Name = "driversGrid";
            this.driversGrid.ReadOnly = true;
            this.driversGrid.RowHeadersWidth = 51;
            this.driversGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driversGrid.Size = new System.Drawing.Size(800, 540);
            this.driversGrid.TabIndex = 0;

            // buttonPanel
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 540);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(800, 60);
            this.buttonPanel.TabIndex = 1;
            this.buttonPanel.BackColor = System.Drawing.Color.LightGray;

            // refreshButton
            this.refreshButton.Location = new System.Drawing.Point(12, 15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(100, 30);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);

            // addButton
            this.addButton.Location = new System.Drawing.Point(130, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 30);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.BackColor = System.Drawing.Color.LightGreen;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);

            // editButton
            this.editButton.Location = new System.Drawing.Point(248, 15);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 30);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Изменить";
            this.editButton.BackColor = System.Drawing.Color.LightBlue;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);

            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(366, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);

            this.buttonPanel.Controls.Add(this.refreshButton);
            this.buttonPanel.Controls.Add(this.addButton);
            this.buttonPanel.Controls.Add(this.editButton);
            this.buttonPanel.Controls.Add(this.deleteButton);

            this.Controls.Add(this.driversGrid);
            this.Controls.Add(this.buttonPanel);

            ((System.ComponentModel.ISupportInitialize)(this.driversGrid)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}