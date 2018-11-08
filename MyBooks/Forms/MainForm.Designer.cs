namespace MyBooks
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.booksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBookButton = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.booksListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksListView.FullRowSelect = true;
            this.booksListView.Location = new System.Drawing.Point(0, 278);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(800, 172);
            this.booksListView.TabIndex = 0;
            this.booksListView.UseCompatibleStateImageBehavior = false;
            this.booksListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 358;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Автор";
            this.columnHeader2.Width = 181;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Описание";
            this.columnHeader3.Width = 155;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(30, 133);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(126, 46);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Добавить книгу";
            this.addBookButton.UseVisualStyleBackColor = true;
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(213, 133);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(133, 46);
            this.addCategory.TabIndex = 1;
            this.addCategory.Text = "Добавить категорию";
            this.addCategory.UseVisualStyleBackColor = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.booksListView);
            this.Name = "MainForm";
            this.Text = "Библиотека";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

