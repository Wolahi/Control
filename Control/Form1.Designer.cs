namespace Control
{
    partial class Form1
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
            this.TableView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Control.DataSet1();
            this.tableTableAdapter = new Control.DataSet1TableAdapters.TableTableAdapter();
            this.Password = new System.Windows.Forms.TextBox();
            this.StartButt = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.AddStroks = new System.Windows.Forms.Button();
            this.ChangeStrocks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableView
            // 
            this.TableView.AutoGenerateColumns = false;
            this.TableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.flagDataGridViewCheckBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.TableView.DataSource = this.tableBindingSource;
            this.TableView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableView.Location = new System.Drawing.Point(0, 0);
            this.TableView.Name = "TableView";
            this.TableView.Size = new System.Drawing.Size(343, 450);
            this.TableView.TabIndex = 0;
            this.TableView.Enter += new System.EventHandler(this.TableView_Enter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flagDataGridViewCheckBoxColumn
            // 
            this.flagDataGridViewCheckBoxColumn.DataPropertyName = "flag";
            this.flagDataGridViewCheckBoxColumn.HeaderText = "flag";
            this.flagDataGridViewCheckBoxColumn.Name = "flagDataGridViewCheckBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(380, 139);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 20);
            this.Password.TabIndex = 1;
            // 
            // StartButt
            // 
            this.StartButt.BackColor = System.Drawing.Color.YellowGreen;
            this.StartButt.Location = new System.Drawing.Point(600, 58);
            this.StartButt.Name = "StartButt";
            this.StartButt.Size = new System.Drawing.Size(166, 49);
            this.StartButt.TabIndex = 2;
            this.StartButt.Text = "Старт";
            this.StartButt.UseVisualStyleBackColor = false;
            this.StartButt.Click += new System.EventHandler(this.StartButt_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(380, 87);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 20);
            this.login.TabIndex = 3;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.LightCoral;
            this.StopButton.Location = new System.Drawing.Point(600, 139);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(166, 43);
            this.StopButton.TabIndex = 4;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AddStroks
            // 
            this.AddStroks.BackColor = System.Drawing.Color.YellowGreen;
            this.AddStroks.Location = new System.Drawing.Point(610, 245);
            this.AddStroks.Name = "AddStroks";
            this.AddStroks.Size = new System.Drawing.Size(142, 41);
            this.AddStroks.TabIndex = 5;
            this.AddStroks.Text = "Добавить строки";
            this.AddStroks.UseVisualStyleBackColor = false;
            this.AddStroks.Click += new System.EventHandler(this.AddStroks_Click);
            // 
            // ChangeStrocks
            // 
            this.ChangeStrocks.BackColor = System.Drawing.Color.YellowGreen;
            this.ChangeStrocks.Location = new System.Drawing.Point(610, 311);
            this.ChangeStrocks.Name = "ChangeStrocks";
            this.ChangeStrocks.Size = new System.Drawing.Size(142, 41);
            this.ChangeStrocks.TabIndex = 6;
            this.ChangeStrocks.Text = "Изменить строки";
            this.ChangeStrocks.UseVisualStyleBackColor = false;
            this.ChangeStrocks.Click += new System.EventHandler(this.ChangeStrocks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(405, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(405, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeStrocks);
            this.Controls.Add(this.AddStroks);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.StartButt);
            this.Controls.Add(this.TableView);
            this.Name = "Form1";
            this.Text = "Задание";
            ((System.ComponentModel.ISupportInitialize)(this.TableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DataSet1TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button StartButt;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AddStroks;
        private System.Windows.Forms.Button ChangeStrocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

