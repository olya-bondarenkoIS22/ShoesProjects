namespace ShoesProject
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelUserName = new Label();
            btnReturn = new Button();
            dgvOrders = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(btnReturn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(14, 11);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 0, 11);
            panel1.Size = new Size(954, 44);
            panel1.TabIndex = 0;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Dock = DockStyle.Right;
            labelUserName.Location = new Point(688, 0);
            labelUserName.Margin = new Padding(4, 0, 4, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(60, 22);
            labelUserName.TabIndex = 8;
            labelUserName.Text = "label1";
            labelUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.MediumSpringGreen;
            btnReturn.Dock = DockStyle.Right;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Location = new Point(748, 0);
            btnReturn.Margin = new Padding(4, 3, 4, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(206, 33);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Вернуться";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(14, 55);
            dgvOrders.Margin = new Padding(4, 3, 4, 3);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(954, 587);
            dgvOrders.TabIndex = 1;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(dgvOrders);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormOrders";
            Padding = new Padding(14, 11, 14, 11);
            Text = "Заказы";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReturn;
        private Label labelUserName;
        private DataGridView dgvOrders;
    }
}