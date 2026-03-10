using Microsoft.EntityFrameworkCore;
using ShoesProject.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesProject
{
    public partial class FormOrders : Form
    {
        public models.User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }
        public FormOrders(models.User user, bool quest)
        {
            InitializeComponent();
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.RowHeadersVisible = false;

            var colDate = new DataGridViewTextBoxColumn();
            colDate.Name = "colDate";
            colDate.FillWeight = 20;
            colDate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colUserDelivery = new DataGridViewTextBoxColumn();
            colUserDelivery.Name = "colUserDelivery";
            colUserDelivery.FillWeight = 50;
            colUserDelivery.DefaultCellStyle.WrapMode = DataGridViewTriState.True; ;

            var colCode = new DataGridViewTextBoxColumn();
            colCode.Name = "colCode";
            colCode.FillWeight = 10;
            colCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.FillWeight = 20;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvOrders.Columns.AddRange(
            [
                colDate, colUserDelivery, colCode, colStatus
            ]);

            CurrentUser = user;
            IsGuest = quest;
            labelUserName.Text = CurrentUser.FullName;
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopDbContext())
                {
                    var orders = db.Orders
                        .Include(i => i.DeliveryPoint)
                        .Include(i => i.User)
                        .Include(i => i.Status)
                        //.Where(i => i.IdUser == CurrentUser.Id) // Фильтр для текущего пользователя
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colDate"].Value = FormatOrderDate(order);

                        row.Cells["colUserDelivery"].Value = FormatUserDelivery(order);

                        row.Cells["colCode"].Value = order.Code.ToString();
                        row.Cells["colCode"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        row.Cells["colStatus"].Value = $"{order.Status.StatusName}";
                        row.Cells["colStatus"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, order);
                    }
                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, Order order)
        {
            if (order.Status.StatusName == "Завершен")
            {
                row.Cells["colStatus"].Style.ForeColor = Color.Green;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
                row.Cells["colStatus"].Style.ForeColor = Color.Blue;
                row.Cells["colCode"].Style.ForeColor = Color.Red;
            }
            
            row.Cells["colStatus"].Style.Font = new Font(
            "Times New Roman",
            12,
            FontStyle.Bold);
        }

        private static string FormatUserDelivery(Order order)
        {
            string deliveryAddress = order.DeliveryPoint?.DeliveryAddress ?? "Адрес не указан";
            return $"Пользователь: {order.User?.FullName ?? "Не указан"}" + Environment.NewLine +
                $"Адрес доставки: {deliveryAddress}" + Environment.NewLine;
        }

        private static string FormatOrderDate(Order order)
        {
            try
            {
                // DateOnly нужно форматировать без времени
                string orderDate = order.OrderDate.ToString("dd.MM.yyyy");
                string deliveryDate = order.DeliveryDate.ToString("dd.MM.yyyy");

                return $"Дата заказа: {orderDate}" + Environment.NewLine +
                    $"Дата доставки: {deliveryDate}" + Environment.NewLine;
            }
            catch
            {
                // Если возникла ошибка, возвращаем значения по умолчанию
                return $"Дата заказа: {order.OrderDate}" + Environment.NewLine +
                    $"Дата доставки: {order.DeliveryDate}" + Environment.NewLine;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
