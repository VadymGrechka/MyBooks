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
            this.components = new System.ComponentModel.Container();
            this.booksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.booksContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteBookMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookButton = new System.Windows.Forms.Button();
            this.booksContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksListView
            // 
            this.booksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.booksListView.ContextMenuStrip = this.booksContextMenu;
            this.booksListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksListView.FullRowSelect = true;
            this.booksListView.Location = new System.Drawing.Point(0, 272);
            this.booksListView.Name = "booksListView";
            this.booksListView.Size = new System.Drawing.Size(800, 178);
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата";
            // 
            // booksContextMenu
            // 
            this.booksContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.booksContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookMenuItem});
            this.booksContextMenu.Name = "contextMenuStrip2";
            this.booksContextMenu.Size = new System.Drawing.Size(211, 56);
            // 
            // deleteBookMenuItem
            // 
            this.deleteBookMenuItem.Name = "deleteBookMenuItem";
            this.deleteBookMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteBookMenuItem.Text = "Удалить";
            this.deleteBookMenuItem.Click += new System.EventHandler(this.deleteBookMenuItem_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(30, 133);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(126, 46);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Добавить книгу";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.booksListView);
            this.Name = "MainForm";
            this.Text = "Библиотека";
            this.booksContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView booksListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip booksContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteBookMenuItem;
    }
}

