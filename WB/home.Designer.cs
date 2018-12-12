namespace WB
{
    partial class home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbvehicle = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtwt1 = new System.Windows.Forms.TextBox();
            this.txtwt2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtnetwt = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.userdbDataSet = new WB.userdbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WB.userdbDataSetTableAdapters.usersTableAdapter();
            this.userdbDataSet1 = new WB.userdbDataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new WB.userdbDataSet1TableAdapters.itemsTableAdapter();
            this.cbharvester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbitem
            // 
            this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbitem.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(102, 57);
            this.cbitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbitem.Name = "cbitem";
            this.cbitem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbitem.Size = new System.Drawing.Size(228, 100);
            this.cbitem.TabIndex = 1;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Type";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbvehicle
            // 
            this.cbvehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbvehicle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvehicle.FormattingEnabled = true;
            this.cbvehicle.Location = new System.Drawing.Point(102, 165);
            this.cbvehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbvehicle.Name = "cbvehicle";
            this.cbvehicle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbvehicle.Size = new System.Drawing.Size(228, 100);
            this.cbvehicle.TabIndex = 2;
            this.cbvehicle.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(336, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit and Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtwt1
            // 
            this.txtwt1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwt1.Location = new System.Drawing.Point(469, 18);
            this.txtwt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwt1.Name = "txtwt1";
            this.txtwt1.Size = new System.Drawing.Size(149, 24);
            this.txtwt1.TabIndex = 3;
            this.txtwt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtwt1.TextChanged += new System.EventHandler(this.txtwt1_TextChanged);
            // 
            // txtwt2
            // 
            this.txtwt2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwt2.Location = new System.Drawing.Point(469, 50);
            this.txtwt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwt2.Name = "txtwt2";
            this.txtwt2.Size = new System.Drawing.Size(149, 24);
            this.txtwt2.TabIndex = 4;
            this.txtwt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtwt2.TextChanged += new System.EventHandler(this.txtwt2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1st Weight";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "2nd Weight";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Net Weight";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "KG";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(621, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "KG";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(621, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "KG";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtticket
            // 
            this.txtticket.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtticket.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtticket.Location = new System.Drawing.Point(102, 20);
            this.txtticket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtticket.Name = "txtticket";
            this.txtticket.ReadOnly = true;
            this.txtticket.Size = new System.Drawing.Size(60, 24);
            this.txtticket.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ticket No.";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtnetwt
            // 
            this.txtnetwt.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtnetwt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetwt.Location = new System.Drawing.Point(469, 82);
            this.txtnetwt.Name = "txtnetwt";
            this.txtnetwt.ReadOnly = true;
            this.txtnetwt.Size = new System.Drawing.Size(149, 24);
            this.txtnetwt.TabIndex = 12;
            this.txtnetwt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdt
            // 
            this.txtdt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdt.Location = new System.Drawing.Point(168, 20);
            this.txtdt.Name = "txtdt";
            this.txtdt.ReadOnly = true;
            this.txtdt.Size = new System.Drawing.Size(162, 24);
            this.txtdt.TabIndex = 13;
            this.txtdt.Text = "date time";
            this.txtdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userdbDataSet
            // 
            this.userdbDataSet.DataSetName = "userdbDataSet";
            this.userdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.userdbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userdbDataSet1
            // 
            this.userdbDataSet1.DataSetName = "userdbDataSet1";
            this.userdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.userdbDataSet1;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // cbharvester
            // 
            this.cbharvester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbharvester.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbharvester.FormattingEnabled = true;
            this.cbharvester.Location = new System.Drawing.Point(102, 273);
            this.cbharvester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbharvester.Name = "cbharvester";
            this.cbharvester.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbharvester.Size = new System.Drawing.Size(228, 100);
            this.cbharvester.TabIndex = 1;
            this.cbharvester.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Harvester";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(102, 381);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit Input Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txtnetwt);
            this.Controls.Add(this.txtticket);
            this.Controls.Add(this.txtwt2);
            this.Controls.Add(this.txtwt1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbvehicle);
            this.Controls.Add(this.cbharvester);
            this.Controls.Add(this.cbitem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "home";
            this.Size = new System.Drawing.Size(677, 426);
            this.Load += new System.EventHandler(this.home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.home_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.userdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbvehicle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtwt1;
        private System.Windows.Forms.TextBox txtwt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtnetwt;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private userdbDataSet1 userdbDataSet1;
        private userdbDataSet userdbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private userdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private userdbDataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ComboBox cbharvester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}
