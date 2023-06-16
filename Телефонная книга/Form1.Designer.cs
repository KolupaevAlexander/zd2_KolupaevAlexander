
namespace Телефонная_книга
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.numbersList = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNumber = new System.Windows.Forms.Button();
            this.searchByName = new System.Windows.Forms.Button();
            this.saveNumbers = new System.Windows.Forms.Button();
            this.deleteNumber = new System.Windows.Forms.Button();
            this.searchedNumbers = new System.Windows.Forms.Label();
            this.sortnumbers = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbersList
            // 
            this.numbersList.FormattingEnabled = true;
            this.numbersList.Location = new System.Drawing.Point(142, 37);
            this.numbersList.Name = "numbersList";
            this.numbersList.Size = new System.Drawing.Size(268, 264);
            this.numbersList.TabIndex = 0;
            this.numbersList.SelectedIndexChanged += new System.EventHandler(this.numbersList_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(106, 20);
            this.name.TabIndex = 1;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(30, 92);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(106, 20);
            this.phone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Телефон";
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(30, 118);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(106, 23);
            this.addNumber.TabIndex = 5;
            this.addNumber.Text = "Добавить";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // searchByName
            // 
            this.searchByName.Location = new System.Drawing.Point(30, 205);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(106, 23);
            this.searchByName.TabIndex = 6;
            this.searchByName.Text = "Поиск по имени";
            this.searchByName.UseVisualStyleBackColor = true;
            this.searchByName.Click += new System.EventHandler(this.searchByName_Click);
            // 
            // saveNumbers
            // 
            this.saveNumbers.Location = new System.Drawing.Point(369, 329);
            this.saveNumbers.Name = "saveNumbers";
            this.saveNumbers.Size = new System.Drawing.Size(100, 23);
            this.saveNumbers.TabIndex = 7;
            this.saveNumbers.Text = "Сохранить";
            this.saveNumbers.UseVisualStyleBackColor = true;
            this.saveNumbers.Click += new System.EventHandler(this.saveNumbers_Click);
            // 
            // deleteNumber
            // 
            this.deleteNumber.Location = new System.Drawing.Point(30, 147);
            this.deleteNumber.Name = "deleteNumber";
            this.deleteNumber.Size = new System.Drawing.Size(106, 23);
            this.deleteNumber.TabIndex = 8;
            this.deleteNumber.Text = "Удалить";
            this.deleteNumber.UseVisualStyleBackColor = true;
            this.deleteNumber.Click += new System.EventHandler(this.deleteNumber_Click);
            // 
            // searchedNumbers
            // 
            this.searchedNumbers.AutoSize = true;
            this.searchedNumbers.Location = new System.Drawing.Point(27, 231);
            this.searchedNumbers.Name = "searchedNumbers";
            this.searchedNumbers.Size = new System.Drawing.Size(109, 13);
            this.searchedNumbers.TabIndex = 10;
            this.searchedNumbers.Text = "Искомые телефоны";
            // 
            // sortnumbers
            // 
            this.sortnumbers.Location = new System.Drawing.Point(30, 176);
            this.sortnumbers.Name = "sortnumbers";
            this.sortnumbers.Size = new System.Drawing.Size(106, 23);
            this.sortnumbers.TabIndex = 11;
            this.sortnumbers.Text = "Сортировка";
            this.sortnumbers.UseVisualStyleBackColor = true;
            this.sortnumbers.Click += new System.EventHandler(this.sortnumbers_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(369, 358);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 393);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sortnumbers);
            this.Controls.Add(this.searchedNumbers);
            this.Controls.Add(this.deleteNumber);
            this.Controls.Add(this.saveNumbers);
            this.Controls.Add(this.searchByName);
            this.Controls.Add(this.addNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.numbersList);
            this.Name = "MainForm";
            this.Text = "Телефонная книга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numbersList;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Button searchByName;
        private System.Windows.Forms.Button saveNumbers;
        private System.Windows.Forms.Button deleteNumber;
        private System.Windows.Forms.Label searchedNumbers;
        private System.Windows.Forms.Button sortnumbers;
        private System.Windows.Forms.Button exit;
    }
}

